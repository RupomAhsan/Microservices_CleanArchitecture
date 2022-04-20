using FluentValidation;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class CreateLookupMasterDTOValidator : AbstractValidator<CreateLookupMasterDTO>
{
    public CreateLookupMasterDTOValidator()
    {
        Include(new ILookupMasterDTOValidator());
    }
}
