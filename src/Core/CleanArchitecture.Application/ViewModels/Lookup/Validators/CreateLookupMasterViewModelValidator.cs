using FluentValidation;

namespace CleanArchitecture.Application.ViewModels.Validators;

public class CreateLookupMasterViewModelValidator : AbstractValidator<CreateLookupMasterViewModel>
{
    public CreateLookupMasterViewModelValidator()
    {
        Include(new ILookupMasterViewModelValidator());
    }
}
