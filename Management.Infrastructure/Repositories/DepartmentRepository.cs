using Management.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.Repositories
{
    public class DepartmentRepository : RepositoryBase<Department>
      , IDepartmentRepository
    {
        public DepartmentRepository(EFContext dbContext) : base(dbContext)
        {
        }
    }
}
