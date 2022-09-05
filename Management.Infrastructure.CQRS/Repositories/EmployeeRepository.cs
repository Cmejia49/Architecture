using Management.Application.CQRS.Interfaces;
using Management.Domain.CQRS.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.CQRS.Repositories
{
    public class EmployeeRepository:RepositoryBase<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(EFContext context) : base(context)
    {

    }
}
}
