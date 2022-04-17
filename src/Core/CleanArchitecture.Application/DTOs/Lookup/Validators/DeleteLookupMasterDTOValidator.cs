using FluentValidation;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class DeleteLookupMasterDTOValidator : AbstractValidator<DeleteLookupMasterDTO>
{
    public DeleteLookupMasterDTOValidator()
    {
        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        RuleFor(p => p.LastModifiedBy).NotNull().WithMessage("{PropertyName} must be present");
    }
}
