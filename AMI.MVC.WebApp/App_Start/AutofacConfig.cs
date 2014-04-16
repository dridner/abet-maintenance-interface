using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using AMI.Business.BaseLogic;
using Autofac.Integration.Mvc;
using System.Reflection;

namespace AMI.MVC.WebApp.App_Start
{
    public static class AutofacConfig
    {
        public static void Configure()
        {
            var container = new ContainerBuilder();

            container.RegisterControllers(Assembly.GetExecutingAssembly());
            container.RegisterAssemblyTypes(typeof(AsyncDBCommandBase<>).Assembly)
                .InNamespace(typeof(AsyncDBCommandBase<>).Namespace);

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container.Build()));
        }
    }
}