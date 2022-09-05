using Management.Domain.Base;
using Management.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Departments
{
    public partial class Department:BaseEntity<short>
    {
        public string Name { get; internal set; }
        public string Description { get; internal set; }

        public virtual ICollection<Employee> Employees { get; internal set; }
    }
}
