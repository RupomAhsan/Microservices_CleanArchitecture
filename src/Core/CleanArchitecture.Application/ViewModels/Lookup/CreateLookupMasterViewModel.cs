namespace CleanArchitecture.Application.ViewModels
{
    public class CreateLookupMasterViewModel: BaseViewModel,ILookpMasterViewModel
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
      //  public bool? IsDeleted { get; set; }

      //  public ICollection<LookupDetailViewModel> LookupDetails { get; set; }
    }
}
