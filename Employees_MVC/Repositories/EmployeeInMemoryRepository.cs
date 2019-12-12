using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employees_MVC.Entities;
using Employees_MVC.Models;

namespace Employees_MVC.Repositories
{
    public class EmployeeInMemoryRepository : IEmployeeRepository
    {
        private IList<Employee> _employees = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Name= "Anna",
                HireDate = DateTime.Now.AddYears(-10) ,
            },

            new Employee()
            {
               Id = 2,
               Name = "Mateusz",
               HireDate = new DateTime(2008, 6, 13)
            },

            new Employee()
            {
               Id = 3,
               Name = "Magdalena",
               HireDate = new DateTime(2008, 10, 10)
            },
            new Employee()
            {
               Id = 4,
               Name = "Michał",
               HireDate = new DateTime(2011, 1, 1)

            },
            new Employee()
            {
               Id = 5,
               Name = "Halina",
               HireDate = new DateTime(2012, 12, 21)
            },
            new Employee()
            {
               Id = 6,
               Name = "Jan",
               HireDate = new DateTime(2016, 3, 8)
            },
            new Employee()
            {
               Id = 7,
               Name = "Cyprian",
               HireDate = new DateTime(2016, 1, 18)
            },
            new Employee()
            {
               Id = 8,
               Name = "Sandra",
               HireDate = new DateTime(2017, 7, 18)
            },
            new Employee()
            {
               Id = 9,
               Name = "Antoni",
               HireDate = new DateTime(2018, 1, 9)
            },
            new Employee()
            {
               Id = 10,
               Name = "Antonina",
               HireDate = new DateTime(2019, 1, 1)
            }

        };

     
        public void Init()
        {
            _employees[0].Manager = _employees[2];
            _employees[1].Manager = _employees[2];
            _employees[2].Manager = _employees[3];
            _employees[4].Manager = _employees[4];
            _employees[5].Manager = _employees[4];
            _employees[6].Manager = _employees[5];
            _employees[7].Manager = _employees[9];
            _employees[8].Manager = _employees[7];
            _employees[9].Manager = _employees[1];

        }
       
        public IEnumerable<EmployeesListItemModel> GetAllEmployees()
        {
            return _employees.Select(e => new EmployeesListItemModel
            {
                Id = e.Id,
                Name = e.Name,
                HireDate = e.HireDate,
                ManagerName = e.Manager?.Name

            }).ToList();
        }

      
        public IEnumerable<EmployeesListItemModel> GetEmployees(string name, DateTime? hireDate, long? managerId)
        {
            IEnumerable<Employee> employees = _employees;
            if(!string.IsNullOrEmpty(name))
            {
                employees = employees.Where(e => e.Name == name);
            }
            if (hireDate.HasValue)
            {
                employees = employees.Where(e => e.HireDate.Year == hireDate.Value.Year && e.HireDate.Month == hireDate.Value.Month && e.HireDate.Day == hireDate.Value.Day);
            }
            if (managerId.HasValue)
            {
                employees = employees.Where(e => e.Manager != null && e.Manager.Id == managerId);
            }

            return employees.Select(e => new EmployeesListItemModel
            {
                Id = e.Id,
                Name = e.Name,
                HireDate = e.HireDate,
                ManagerName = e.Manager?.Name

            }).ToList();

        }
    }
}