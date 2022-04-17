using FluentValidation;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Application.ViewModels.Lookup;
using CleanArchitecture.Application.ViewModels.Validators;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators;

public class UpdateLookupMasterViewModelValidator : AbstractValidator<UpdateLookupMasterViewModel>
{
    public UpdateLookupMasterViewModelValidator()
    {
        Include(new ILookupMasterViewModelValidator());

        RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        RuleFor(p => p.IsActive).NotNull().WithMessage("{PropertyName} must be present");
    }
}
