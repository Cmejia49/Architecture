using Management.Application.Services.Employees;
using Management.Domain.Departments;
using Management.Domain.Employees;
using Management.Domain.Interfaces;
using Management.Infrastructure;
using Management.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Management.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>))
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IDepartmentRepository, DepartmentRepository>();
        }

        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            return services
                .AddScoped<IUnitOfWork, UnitOfWork>();
        }

        public static IServiceCollection AddDatabase(this IServiceCollection services
            , IConfiguration configuration)
        {
            return services.AddDbContext<EFContext>(options =>
                     options.UseSqlServer(configuration.GetConnectionString("DefualtConnection")));
        }

        public static IServiceCollection AddBusinessServices(this IServiceCollection services
           )
        {
            return services
                .AddScoped<EmployeeService>();
        }
    }
}

