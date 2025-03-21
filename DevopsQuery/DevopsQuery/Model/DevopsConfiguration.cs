//*********************************************************************************************************************************
// File Name			:	DevopsConfiguration.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

namespace DevopsQuery.Model
{
    public class DevopsConfiguration
    {
        public string? DevOpsUrl { get; set; }
        public string? PersonalAccessToken { get; set; }
        public List<string>? Projects { get; set; }
        public string? Query { get; set; }
        public List<AssignedUser>? AssignedUsers { get; set; }
        public List<RequiredField>? RequiredFields { get; set; }
        public EmailSettings Email { get; set; }

        public DevopsConfiguration()
        {
            AssignedUsers = new List<AssignedUser>();
            RequiredFields = new List<RequiredField>();
        }
    }
}