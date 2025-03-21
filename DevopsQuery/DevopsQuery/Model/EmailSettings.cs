//*********************************************************************************************************************************
// File Name			:	EmailSettings.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

namespace DevopsQuery.Model
{
    public class EmailSettings
    {
        public string? SmtpHost { get; set; }
        public int Port { get; set; }
        public string? SenderName { get; set; }
        public string? SenderEmail { get; set; }
        public string? SenderPassword { get; set; }
        public string? Subject { get; set; }
        public string? MailTriggerTime { get; set; }
        public bool IsPasswordEncrypted { get; set; }
        public bool SkipWeekend { get; set; }
        public string? Body { get; internal set; }
    }
}
