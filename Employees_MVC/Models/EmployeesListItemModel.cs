
using System;
using System.ComponentModel.DataAnnotations;


namespace Employees_MVC.Models
{
    public class EmployeesListItemModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        public string ManagerName { get; set; }


    }
}