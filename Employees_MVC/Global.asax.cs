using Employees_MVC.Repositories;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Employees_MVC.Infrastructure;
using Employees_MVC.Entities;

namespace Employees_MVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);




            ControllerBuilder.Current.SetControllerFactory(new NinjectControlllerFactory(CreateKernel()));

            //using (var ctx = new EmployeesContext())
            //{
            //    var employee = new Employee()
            //    {

            //        Name = "Anna",
            //        HireDate = new DateTime(2007, 1, 18)

            //    };
            //    ctx.Employees.Add(employee);

            //    var employee2 = new Employee()
            //    {
            //        Id = 2,
            //        Name = "Mateusz",
            //        HireDate = new DateTime(2008, 6, 13)


            //    };

            //    var employee3 = new Employee()
            //    {
            //        Id = 3,
            //        Name = "Magdalena",
            //        HireDate = new DateTime(2008, 10, 10)

            //    };
            //    var employee4 = new Employee()
            //    {
            //        Id = 4,
            //        Name = "Michał",
            //        HireDate = new DateTime(2011, 1, 1)

            //    };
            //    var employee5 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Halina",
            //        HireDate = new DateTime(2012, 12, 21)
            //    };
            //    var employee6 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Jan",
            //        HireDate = new DateTime(2016, 3, 8)
            //    };
            //    var employee7 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Cyprian",
            //        HireDate = new DateTime(2016, 1, 18)
            //    };
            //    var employee8 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Sandra",
            //        HireDate = new DateTime(2017, 7, 18)
            //    };
            //    var employee9 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Antoni",
            //        HireDate = new DateTime(2018, 1, 9)
            //    };
            //    var employee10 = new Employee()
            //    {
            //        Id = 5,
            //        Name = "Antonina",
            //        HireDate = new DateTime(2019, 1, 1)
            //    };

            //    ctx.Employees.Add(employee);
            //    ctx.Employees.Add(employee2);
            //    ctx.Employees.Add(employee3);
            //    ctx.Employees.Add(employee4);
            //    ctx.Employees.Add(employee5);
            //    ctx.Employees.Add(employee6);
            //    ctx.Employees.Add(employee7);
            //    ctx.Employees.Add(employee8);
            //    ctx.Employees.Add(employee9);
            //    ctx.Employees.Add(employee10);



            //    ctx.SaveChanges();

            //    var employees = ctx.Employees.ToList();
            //}



        }
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<IEmployeeRepository>().To<EmployeeInMemoryRepository>().InSingletonScope();

            return kernel;
        }
    }
}
