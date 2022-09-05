using Management.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Employees
{
    public interface IEmployeeRepository:IAsyncRepository<Employee>
    {
    }
}
