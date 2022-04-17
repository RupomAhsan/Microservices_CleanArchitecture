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
    public class LookupMasterEntity : BaseAuditEntity
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }

        public List<LookupDetailEntity> LookupDetails { get; set; }
    }
}
