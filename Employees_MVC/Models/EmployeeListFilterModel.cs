using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees_MVC.Models
{
    public class EmployeeListFilterModel
    {
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }

        public IEnumerable<SelectListItem>Managers { get; set; }
        public long? ManagerId { get; set; }
    }
}