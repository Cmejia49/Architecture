using FluentValidation;
using FluentValidation.Results;
using Management.Application.CQRS.Interfaces;
using Management.Domain.CQRS.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Commands.AddNewEmployee
{
    public class AddNewEmployeeHandler : ICommandHandler<AddNewEmployeeCommand>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public AddNewEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task Handle(AddNewEmployeeCommand command)
        {
            var validator = new AddNewEmployeeValidator();
            ValidationResult results = validator.Validate(command);
            bool validationSucceeded = results.IsValid;
            if (!validationSucceeded)
            {
                var failures = results.Errors.ToList();
                var message = new StringBuilder();
                failures.ForEach(f => { message.Append(f.ErrorMessage + Environment.NewLine); });
                throw new ValidationException(message.ToString());
            }
            //Create A Mapper
            var employee = new Employee
            {
            
            };
            _employeeRepository.AddAsync(employee);

            //Command must be processed asynchronously, so I used an Emty Task.
            //In the real world, saving data is an asynchronous operation, we use something like _context. SaveChangesAsync ();
            _employeeRepository.SaveChangeAsync();

        }
    }
}
