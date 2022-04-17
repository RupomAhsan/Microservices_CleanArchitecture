using CleanArchitecture.Utility.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Utility.Enumerations
{
    public enum LocationPointTypeEnum
    {
        [LocalizedDescription("From")]
        [LocalizedDescriptionValue("From")]
        From,
        [LocalizedDescription("To")]
        [LocalizedDescriptionValue("To")]
        To
    }
}
