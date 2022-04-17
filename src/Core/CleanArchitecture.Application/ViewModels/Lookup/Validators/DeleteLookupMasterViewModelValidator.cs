using FluentValidation;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.Lookup;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class DeleteLookupMasterViewModelValidator : AbstractValidator<DeleteLookupMasterViewModel>
{
    public DeleteLookupMasterViewModelValidator()
    {
        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        RuleFor(p => p.IsDeleted).NotNull().WithMessage("{PropertyName} must be present");
    }
}
