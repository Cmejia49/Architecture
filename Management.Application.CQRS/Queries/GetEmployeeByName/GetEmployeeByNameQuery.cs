using Management.Application.CQRS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Queries.GetEmployeeByName
{
    public class GetEmployeeByNameQuery : IQuery
    {
        public string Search { get; set; }
    }
}
