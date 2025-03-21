//*********************************************************************************************************************************
// File Name			:	EmailManager.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

using DevopsQuery.Model;
using Encryptor;
using System.Net;
using System.Net.Mail;

namespace DevopsQuery
{
    public class EmailManager
    {
        private DevopsConfiguration? _devopsConfig;

        private List<List<ResultDataSet>> _devopsFetchedData;

        public EmailManager(DevopsConfiguration? devopsConfig, List<List<ResultDataSet>> devopsFetchedData)
        {
            _devopsConfig = devopsConfig;
            _devopsFetchedData = devopsFetchedData;
        }

        public void SendEmail()
        {
            try
            {
                var receipients = string.Join(";",
                       _devopsConfig?.AssignedUsers?.
                       FindAll(u => u.SendReport == true).Select(a => a.EmailId).ToArray());


                NetworkCredential credentials = new(_devopsConfig?.Email.SenderEmail, GetPassword());
                SmtpClient client = new(_devopsConfig?.Email.SmtpHost)
                {
                    Port = _devopsConfig?.Email.Port ?? 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    EnableSsl = true,
                    Credentials = credentials
                };

                MailMessage message = new(_devopsConfig?.Email.SenderEmail ?? string.Empty, _devopsConfig?.Email.SenderEmail)
                {
                    Subject = $"{_devopsConfig?.Email.Subject} : {DateTime.Now:dd-MMM-yyyy HH:mm:ss}",
                    Body = GetEmailBody(),
                    IsBodyHtml = true
                };

                var toUsers = _devopsConfig?.AssignedUsers?.
                       FindAll(u => u.SendReport == true).Select(a => a.EmailId).ToArray();
                if (toUsers !=null)
                {
                    foreach (var receipient in toUsers)
                    {
                        message.To.Add(receipient);
                    }
                    
                    client.Send(message); 
                }
                else
                {
                    Console.WriteLine("No recipients mail configured");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private string GetPassword()
        {
            if (_devopsConfig?.Email?.IsPasswordEncrypted ?? false)
                return DecryptPassword(_devopsConfig?.Email.SenderPassword);
            else
                return _devopsConfig?.Email?.SenderPassword ?? string.Empty;
        }

        private string DecryptPassword(string? senderPassword)
        {
            return EncryptionHandler.Decrypt(senderPassword);
        }

        private string GetEmailBody()
        {
            var fileName = "MessageBody.txt";
            var htmlBody = File.ReadAllText(fileName).Trim();
            htmlBody = htmlBody.Replace("{{TableData}}", ConstructTable());
            return htmlBody.Replace("{{SenderName}}", _devopsConfig?.Email.SenderName);
        }

        private string ConstructTable()
        {
            if (_devopsFetchedData.Count == 0)
                return "<h4>**No records found<h4><br/>";

            Dictionary<string, int> headers = new();
            return $"{ConstructHeaderColumn(headers)}{PopulateDataRows(headers)}";
        }
        private string ConstructHeaderColumn(Dictionary<string, int> headers)
        {
            int iPos = 0;
            var tbHeader = "<tr>";

            foreach (var resultDatas in _devopsFetchedData)
            {
                foreach (var resData in resultDatas)
                {
                    if (!headers.ContainsKey(resData.Name))
                    {
                        headers.Add(resData.Name, iPos);
                        tbHeader = $"{tbHeader}<th>{resData.Name}</th>";
                        iPos++;
                    }
                }
            }
            return $"{tbHeader}</tr>";
        }

        private string PopulateDataRows(Dictionary<string, int> headers)
        {
            var tbData = string.Empty;
            var tbRows = string.Empty;
            foreach (var resultDatas in _devopsFetchedData)
            {
                tbData = "<tr>";
                foreach (var headerName in headers.Keys)
                {
                    var value = resultDatas.Find(a => a.Name == headerName)?.Value ?? string.Empty;
                    tbData = $"{tbData}<td>{value}</td>";
                }
                tbRows = $"{tbRows}{tbData}</tr>";
            }
            return tbRows;
        }
    }
}