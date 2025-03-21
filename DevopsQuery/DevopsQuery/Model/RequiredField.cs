//*********************************************************************************************************************************
// File Name			:	RequiredField.cs
// Author				:	Anand Naikar <anandyn29@gmail.com> 
// Description			:	Initial Version
// Date(dd-MM-yyyy)		:	2-12-2022
// Copyright (c) | All Rights Reserved
//*********************************************************************************************************************************

namespace DevopsQuery.Model
{
    public class RequiredField
    {
        public string? Key { get; set; }
        public string? DisplayName { get; set; }
        public bool? Required { get; set; }
    }
}