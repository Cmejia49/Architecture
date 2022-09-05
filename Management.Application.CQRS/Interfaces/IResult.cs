using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Application.CQRS.Interfaces
{
    public interface IResult
    {
    }

    public interface IListResult : ICollection<IResult>
    {
    }
}
