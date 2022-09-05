using Management.Domain.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Departments
{
    public partial class Department
    {
        public Department()
        {
            Employees = new HashSet<Employee>();
        }

        public Department(string name, string description) : this()
        {
            this.Update(name, description);
        }

        public void Update(string name , string description)
        {
            Name = name;
            Description = description;
        }
    }
}
