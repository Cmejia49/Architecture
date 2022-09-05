using Management.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Domain.Employees.Events
{
    public class OnPayslipAddedDomainEvent:BaseDomainEvent
    {
        public Payslip Payslip { get; set; }

    }
}
