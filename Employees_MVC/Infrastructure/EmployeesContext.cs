using Employees_MVC.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Employees_MVC.Infrastructure
{
    public class EmployeesContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}