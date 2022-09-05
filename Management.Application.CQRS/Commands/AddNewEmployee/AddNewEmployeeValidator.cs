using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Commands.AddNewEmployee
{
    public class AddNewEmployeeValidator: AbstractValidator<AddNewEmployeeCommand>
    {
        public AddNewEmployeeValidator()
        {
            RuleFor(p => p.FirstName).NotEmpty().WithMessage("Product Name must be specifed")
                        .MaximumLength(100).WithMessage("Product Name exceeds the authorized size 100");
            RuleFor(p => p.LastName).MaximumLength(400).WithMessage("Product Description exceeds the authorized size which is 400");
        }
    }
}
