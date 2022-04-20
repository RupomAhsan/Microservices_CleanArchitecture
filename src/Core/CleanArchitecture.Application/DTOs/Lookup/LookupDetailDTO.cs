﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Lookup
{
    public class LookupDetailDTO
    {
        public CreateLookupMasterDTO LookupMaster { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string DisplayName { get; set; }
        public string? GroupName { get; set; }
        public string? Miscellaneous { get; set; }
        public int SortOrder { get; set; }
        public bool? IsDefault { get; set; }
    }
}
