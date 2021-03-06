using Autofac;
using Autofac.Integration.Mvc;
using Base.Concrete;
using Base.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace _0510
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // autofac
            AutofacRegistration();
        }

        public static void AutofacRegistration()
        {
            var builder = new ContainerBuilder();
            // Controller
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<EFAccount>().As<IAccount>();
            builder.RegisterType<PenSevice>().As<IPen>();

            //builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
            // .Where(t => t.Name.StartsWith("Repository"))
            // .AsImplementedInterfaces();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }

    }
}
