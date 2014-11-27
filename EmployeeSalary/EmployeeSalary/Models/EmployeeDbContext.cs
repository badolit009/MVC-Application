using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeSalary.Models
{
    public class EmployeeDbContext:DbContext
    {
       public DbSet<Employee> Employees { set; get; }
        public DbSet<Designation> Designations { get; set; }
    }
}