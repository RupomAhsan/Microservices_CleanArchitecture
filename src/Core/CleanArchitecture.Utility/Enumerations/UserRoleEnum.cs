using CleanArchitecture.Utility.Helpers;

namespace CleanArchitecture.Utility.Enumerations;

public enum UserRoleEnum
{
    [LocalizedDescription("Rider")]
    [LocalizedDescriptionValue("Rider")]
    Rider,

    [LocalizedDescription("Administrator")]
    [LocalizedDescriptionValue("Administrator")]
    Administrator
}
