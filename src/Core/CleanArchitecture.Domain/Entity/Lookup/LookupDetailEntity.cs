using CleanArchitecture.Auditing;
using CleanArchitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entity.Lookup
{
    [NotAuditable]
    public class LookupDetailEntity : BaseAuditDetailEntity
    {
        public LookupMasterEntity LookupMaster { get; set; }
        public int LookupMasterId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string DisplayName { get; set; }
        public string? GroupName { get; set; }
        public string? Miscellaneous { get; set; }
        public int SortOrder { get; set; }
        public bool? IsDefault { get; set; }
    }
}
