using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Todo.DataAccess.Models;

namespace Todo.Business.Validator.FluentValidator
{
    public class CompanyValidator : AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("must be populated in for company of type 'Name'");
        }
    }
}
