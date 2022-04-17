using CleanArchitecture.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Lookup
{
    public class DeleteLookupMasterDTO : BaseDto
    {
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }


    }
}
