using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Lookup
{
    public class CreateLookupMasterViewModel:ILookpMasterDTO
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
