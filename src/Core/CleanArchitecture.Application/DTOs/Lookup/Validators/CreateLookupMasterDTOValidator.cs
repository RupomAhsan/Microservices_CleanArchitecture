using FluentValidation;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class CreateLookupMasterDTOValidator : AbstractValidator<CreateLookupMasterViewModel>
{
    public CreateLookupMasterDTOValidator()
    {
        Include(new ILookupMasterDTOValidator());
    }
}
