
using Employees_MVC.Models;
using System;
using System.Collections.Generic;


namespace Employees_MVC.Repositories
{
    public interface IEmployeeRepository
    {
        void Init();
        IEnumerable<EmployeesListItemModel> GetAllEmployees();

        IEnumerable<EmployeesListItemModel> GetEmployees(string name, DateTime? hireDate, long? managerId);

    }
}