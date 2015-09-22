using Autofac;
using Autofac.Integration.Mvc;
using BackgroundWorkingWithMVC.Application.BackgroudWorkers.CacheWorkers;
using BackgroundWorkingWithMVC.Application.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BackgroundWorkingWithMVC.Application
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = Bootstrapper.Initialize();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            var categoriesCacheWorker = container.Resolve<CategoriesCacheWorker>();
            categoriesCacheWorker.Initialize();
        }
    }

}
