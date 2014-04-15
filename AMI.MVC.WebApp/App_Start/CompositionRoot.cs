using System.Reflection;
using AMI.MVC.WebApp.DI;
using AMI.MVC.WebApp.DI.Autofac;
using AMI.MVC.WebApp.DI.Autofac.Modules;
using Autofac;
using Autofac.Core;

public class CompositionRoot
{
    public static IDependencyInjectionContainer Compose()
    {
// Create a container builder
        var builder = new ContainerBuilder();
        builder.RegisterModule(new MvcSiteMapProviderModule());
        builder.RegisterModule(new MvcModule());
        builder.RegisterAssemblyTypes(Assembly.Load("AMI.Business"));

// Create the DI container
        var container = builder.Build();

// Return our DI container wrapper instance
        return new AutofacDependencyInjectionContainer(container);
    }
}

