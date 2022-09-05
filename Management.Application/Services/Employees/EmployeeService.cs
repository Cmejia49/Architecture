using Management.Application.Dtos.EmployeeDtos;
using Management.Domain.Employees;
using Management.Domain.Interfaces;

namespace Management.Application.Services.Employees
{
    public class EmployeeService:BaseService
    {
        public EmployeeService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
          
        }

        public async Task<AddEmployeeResponse> AddNewAsync(AddEmployeeRequest model)
        {
            // You can you some mapping tools as such as AutoMapper
            var user = new Employee(model.UserName
                , model.FirstName
                , model.LastName
                , model.Address
                , model.BirthDate
                , model.DepartmentId.Value);

            var repository = UnitOfWork.AsyncRepository<Employee>();
            await repository.AddAsync(user);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddEmployeeResponse()
            {
                Id = user.Id,
                UserName = user.UserName
            };

            return response;
        }


        public async Task<List<EmployeeInfoDTO>> SearchAsync(GetEmployeeRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<Employee>();
            var users = await repository
                .ListAsync(_ => _.UserName.Contains(request.Search));

            var userDTOs = users.Select(_ => new EmployeeInfoDTO()
            {
                Address = _.Address,
                BirthDate = _.BirthDate,
                DepartmentId = _.DepartmentId,
                FirstName = _.FirstName,
                Id = _.Id,
                LastName = _.LastName,
                UserName = _.UserName
            })
            .ToList();

            return userDTOs;
        }
    }
}
