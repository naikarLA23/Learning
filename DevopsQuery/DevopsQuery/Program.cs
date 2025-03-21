//*********************************************************************************************************************************
// File Name			:	Program.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

using DevopsQuery;
using DevopsQuery.Model;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var fetchData = false;
        var fileName = "DevopsConfig.json";
        var waitTimeInMin = 30;
        var lastMailSent = DateTime.Now;
        var sendTimeHour = 0;

        while (true)
        {
            try
            {
                if (!fetchData)
                {
                    Console.WriteLine("Started processing");
                    
                    sendTimeHour = StartProcessing(fileName);
                    lastMailSent = DateTime.Now;
                    fetchData = true;
                    Console.WriteLine("Email sent");
                    return;//exit app if add as scheduler otherwise comment line if want to run as service
                }
                else
                {
                    if (lastMailSent.Day != DateTime.Now.Day)
                    {
                        if (DateTime.Now.Hour >= sendTimeHour)
                        {
                            fetchData = false;
                            continue;
                        }
                    }
                    else
                        Console.WriteLine("Skipped sending mail!!!");

                    Console.WriteLine($"Waiting for {waitTimeInMin} minute");

                    Thread.Sleep(waitTimeInMin * 60 * 1000);
                }
                Console.WriteLine("Iterating again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    private static int StartProcessing(string fileName)
    {
        Console.WriteLine("Reading configuration...");
        var jsonData = File.ReadAllText(fileName).Trim();
        var devopsConfig = JsonSerializer.Deserialize<DevopsConfiguration>(jsonData);

        int.TryParse(devopsConfig.Email.MailTriggerTime, out int sendTime);

        if (!devopsConfig.Email.SkipWeekend ||
            (DateTime.Now.DayOfWeek != DayOfWeek.Saturday || DateTime.Now.DayOfWeek != DayOfWeek.Sunday))
        {
            var queryExecutor = new QueryExecutor(devopsConfig);
            var devopsFetchedData = queryExecutor.GetDevopsTasks();
            Console.WriteLine("Data fetched from DevOps");

            EmailManager emailManager = new(devopsConfig, devopsFetchedData);
            Console.WriteLine("Sending email...");
            emailManager.SendEmail();
            Console.WriteLine("Email sent!!!");
        }
        else
            Console.WriteLine("Skipped sending mail!!!");

        return sendTime;
    }
}