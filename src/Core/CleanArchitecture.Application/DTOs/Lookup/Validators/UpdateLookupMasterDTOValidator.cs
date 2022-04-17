using FluentValidation;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class UpdateLookupMasterDTOValidator : AbstractValidator<UpdateLookupMasterDTO>
{
    public UpdateLookupMasterDTOValidator()
    {
        Include(new ILookupMasterDTOValidator());

        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        RuleFor(p => p.LastModifiedBy).NotNull().WithMessage("{PropertyName} must be present");
    }
}
