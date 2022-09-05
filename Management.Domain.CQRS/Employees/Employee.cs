using Management.Domain.CQRS.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.CQRS.Employees
{
    public partial class Employee : BaseEntity<int>
    {
        public Employee()
        {
            PaySlips = new HashSet<Payslip>();
        }


        public string UserName { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Address { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public int DepartmentId { get; private set; }
        public float CoefficientsSalary { get; private set; }
        public virtual ICollection<Payslip> PaySlips { get; private set; }
    }
}
