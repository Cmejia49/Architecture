using Management.Application.CQRS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Queries.GetEmployeeByName
{
    public class GetEmployeeByNameQueryHandler : IQueryHandler<GetEmployeeByNameQuery>
    {
        private readonly IEmployeeRepository _employeeRepository;

        public GetEmployeeByNameQueryHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public IList<IResult> Handle(GetEmployeeByNameQuery query)
        {
           

           
        }
    }
}
