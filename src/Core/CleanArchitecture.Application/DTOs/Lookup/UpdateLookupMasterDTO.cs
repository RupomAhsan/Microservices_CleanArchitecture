using CleanArchitecture.Application.DTOs.Common;

namespace CleanArchitecture.Application.DTOs.Lookup;

public class UpdateLookupMasterDTO : BaseDto, ILookpMasterDTO
{
    public string Type { get; set; }
    public string Description { get; set; }
    public bool? IsActive { get; set; }
    public string LastModifiedBy { get; set; }
    public DateTime? LastModifiedDate { get; set; }


}
