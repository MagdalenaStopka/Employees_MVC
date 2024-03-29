﻿using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Employees_MVC.Infrastructure
{
    public class NinjectControlllerFactory : DefaultControllerFactory
    {
        public IKernel Kernel { get; }

        public NinjectControlllerFactory(IKernel kernel)
        {
            this.Kernel = kernel;
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {

            IController controller = null;

            if (controllerType != null)
            {
                controller = (IController)this.Kernel.Get(controllerType);
            }

            return controller;
        }
    }
}