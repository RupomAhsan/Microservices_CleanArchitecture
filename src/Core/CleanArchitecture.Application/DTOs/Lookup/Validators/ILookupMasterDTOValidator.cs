using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Lookup.Validators
{
    public class ILookupMasterDTOValidator : AbstractValidator<ILookpMasterDTO>
    {
        public ILookupMasterDTOValidator()
        {
            RuleFor(p => p.Type)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Type)
                .MaximumLength(150).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            //RuleFor(p => p.DefaultDays)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
            //    .LessThan(100).WithMessage("{PropertyName} must be less than {ComparisonValue}.");
        }
    }
}
