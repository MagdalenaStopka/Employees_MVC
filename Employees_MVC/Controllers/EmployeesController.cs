using Employees_MVC.Entities;
using Employees_MVC.Models;
using Employees_MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employees_MVC.Controllers
{
    public class EmployeesController : Controller
    {
        
        private IEmployeeRepository _repository;

        public EmployeesController(IEmployeeRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public ActionResult List()
        {
            _repository.Init();
            EmployeeListFilterModel filter = new EmployeeListFilterModel();
            filter.Managers = _repository.GetAllEmployees().Select
                (e => new SelectListItem
                {
                    Value = e.Id.ToString(),
                    Text = e.Name

                });
           
            return View(filter);

        }
        [HttpGet]
        public ActionResult Grid(EmployeeListFilterModel model)
        {
           var employees= _repository.GetEmployees(model.Name, model.HireDate, model.ManagerId);
            return PartialView(employees);
        }

    }
}