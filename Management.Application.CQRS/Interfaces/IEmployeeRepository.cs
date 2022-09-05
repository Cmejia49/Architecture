using Management.Domain.CQRS.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Interfaces
{
    public interface IEmployeeRepository:IAsyncRepository<Employee>
    {
    }
}
