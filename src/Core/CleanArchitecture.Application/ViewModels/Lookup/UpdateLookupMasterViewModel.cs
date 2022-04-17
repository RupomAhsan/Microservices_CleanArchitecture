using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.ViewModels.Lookup
{
    public class UpdateLookupMasterViewModel :BaseViewModel, ILookpMasterViewModel
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }       

       // public ICollection<LookupDetailViewModel> LookupDetails { get; set; }
    }
}
