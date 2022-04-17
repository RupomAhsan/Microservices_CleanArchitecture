namespace CleanArchitecture.Application.ViewModels
{
    public class LookupDetailViewModel
    {
        public CreateLookupMasterViewModel LookupMaster { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string DisplayName { get; set; }
        public string? GroupName { get; set; }
        public string? Miscellaneous { get; set; }
        public int SortOrder { get; set; }
        public bool? IsDefault { get; set; }
    }
}
