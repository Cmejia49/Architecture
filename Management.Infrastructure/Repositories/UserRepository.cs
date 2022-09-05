using Management.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.Repositories
{
    public class EmployeeRepository:RepositoryBase<Employee> , IEmployeeRepository
    {
        public EmployeeRepository(EFContext context):base(context)
        {

        }
    }
}
