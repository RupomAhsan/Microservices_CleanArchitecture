using CleanArchitecture.Application.DTOs.Common;
using CleanArchitecture.Utility.Enumerations;

namespace CleanArchitecture.Application.DTOs.Lookup;

public class LookupMasterDTO : BaseDto, ILookpMasterDTO
{
    public string Type { get; set; }
    public string Description { get ; set; }
}
