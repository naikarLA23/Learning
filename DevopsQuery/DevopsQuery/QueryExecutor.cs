//*********************************************************************************************************************************
// File Name			:	QueryExecutor.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

using DevopsQuery.Model;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.TeamFoundation.WorkItemTracking.WebApi.Models;
using Microsoft.VisualStudio.Services.Common;

public class QueryExecutor
{
    public DevopsConfiguration? DevopsConfiguration { get; private set; }

    public QueryExecutor(DevopsConfiguration? devopsConfiguration)
    {
        DevopsConfiguration = devopsConfiguration;
    }

    public List<List<ResultDataSet>> GetDevopsTasks()
    {
        var task = QueryOpenBugs();
        task.Wait();
        var taskResults = task.Result;

        List<List<ResultDataSet>> results = new ();
        List<ResultDataSet> resultSets = new();
        foreach (var taskRes in taskResults)
        {
            resultSets = new();

            foreach (var field in taskRes.Fields)
            {
                var item = DevopsConfiguration.RequiredFields.Find(a => a.Key == field.Key);
                if (item?.Required ?? false)
                {
                    var value = string.Empty;
                    if (field.Value is Microsoft.VisualStudio.Services.WebApi.IdentityRef)
                    {
                        value = (field.Value as Microsoft.VisualStudio.Services.WebApi.IdentityRef)?.DisplayName;
                    }
                    else if(field.Value is DateTime)
                    {
                        DateTime.TryParse(field.Value.ToString(), out DateTime dt);
                        value = dt.ToString("dd-MMM-yyyy");
                    }
                    else
                    {
                        value = field.Value.ToString();
                    }

                    resultSets.Add(new ResultDataSet()
                    {
                        Name = item.DisplayName,
                        Value = value
                    });
                }
            }
            results.Add(resultSets);
        }
        return results;
    }


    public async Task<IList<WorkItem>> QueryOpenBugs()
    {
        try
        {
            using (var httpClient = 
                new WorkItemTrackingHttpClient(new Uri(DevopsConfiguration?.DevOpsUrl??""),
                new VssBasicCredential(string.Empty, DevopsConfiguration?.PersonalAccessToken)))
            {
                var result = await httpClient.QueryByWiqlAsync(new Wiql() { Query = GetComposeQuery() }).ConfigureAwait(false);
                var ids = result.WorkItems.Select(item => item.Id).ToArray();

                if (ids.Length == 0)
                    return Array.Empty<WorkItem>();

                var res =  await httpClient.GetWorkItemsAsync(ids, GetRequiredFields(), result.AsOf).ConfigureAwait(false);
                return res;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        return null;
    }

    private string[] GetRequiredFields()
    {
        List<string> requiredFields = new();
        if (DevopsConfiguration?.RequiredFields != null)
        {
            foreach (var fields in DevopsConfiguration.RequiredFields)
            {
                requiredFields.Add(fields.Key ?? string.Empty);
            }
        }
        return requiredFields.ToArray();
    }

    private string GetComposeQuery()
    {
        var query = DevopsConfiguration?.Query ?? string.Empty;

        int startIndex = 0;

        while (true)
        {
            var replaceKeyStartIndex = query.IndexOf("{{", startIndex);

            if (replaceKeyStartIndex == -1)
                break;

            var replaceKeyEndIndex = query.IndexOf("}}", replaceKeyStartIndex);
            var replaceKey = query[(replaceKeyStartIndex + 2)..replaceKeyEndIndex];

            query = ReplacePlaceHolders(query, replaceKeyStartIndex, replaceKey);
            startIndex = replaceKeyEndIndex; 
        }

        return query;
    }

    private string ReplacePlaceHolders(string query, int replaceKeyStartIndex, string replaceKey)
    {
        var replaceValue = string.Empty;
        var queryChild = query.Substring(replaceKeyStartIndex - 1, 1) == "$";
        if (queryChild)
        {
            var childs = replaceKey.Split(new char[] { '.' });
            if (childs[0] == "AssignedUsers")
            {
                replaceValue = GetUserDetails(childs[1]);
            }
            query = query.Replace($"${{{{{replaceKey}}}}}",replaceValue);
        }
        else
        {
            if (replaceKey == "Projects")
            {
                replaceValue = string.Join(",", DevopsConfiguration.Projects.Select(a => "'" + a + "'"));
            }
            query = query.Replace($"{{{{{replaceKey}}}}}", replaceValue);
        }

        return query;
    }

    private string GetUserDetails(string propertyName)
    {
        if (propertyName == "Name")
            return string.Join(",", DevopsConfiguration.AssignedUsers.Select(a => "'" + a.Name + "'"));
        else if (propertyName == "EmailId")
            return string.Join(",", DevopsConfiguration.AssignedUsers.Select(a => "'" + a.EmailId + "'"));
        return string.Empty;
    }
}