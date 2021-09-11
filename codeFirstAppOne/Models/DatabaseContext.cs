using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codeFirstAppOne.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions options):base(options) 
        {
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Employee>().HasData(new Employee { 
            EmployeeId=1,
            FirstName="Udith",
            LastName="Liyanage",
            Email="udithLiyanage@gmail.com",
            DateOfBirth=new DateTime(2000,02,01),
            PhoneNumber="999-888-7777"
            },new Employee {
                EmployeeId = 2,
                FirstName = "Himashi",
                LastName = "Ranaviraja",
                Email = "himashiranaviraja@gmail.com",
                DateOfBirth = new DateTime(2012, 02, 01),
                PhoneNumber = "999-888-7777"
            });
        }
    }
}
