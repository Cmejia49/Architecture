using Management.Domain.CQRS.Employees;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management.Infrastructure.CQRS
{
    public class EFContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Payslip> Payslips { get; set; }
        public EFContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

    }
}
