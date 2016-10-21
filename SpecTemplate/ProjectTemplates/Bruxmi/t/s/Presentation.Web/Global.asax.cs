using Autofac;
using Autofac.Integration.WebApi;
using Core;
using Core.Extensions;
using Core.Interfaces.Services.Query;
using Core.Registration.Container;
using Presentation.Web.App_Start;
using System;
using System.Reflection;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Presentation.Web
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Error(object sender, EventArgs e)
        {
            var exception = this.Server.GetLastError();
            this.Server.ClearError();
            AppExceptionHandler.Current.Handle(exception);
            exception.Rethrow();
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            var builder = AppContainer.Create();
            WebBootstrapper.InitializeProduction(builder);
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            AppContainer.Factory = builder.Build();
            AppConfiguration.Factory = AppContainer.Current.Resolve<IAppConfigurationService>();
            var loggerBuilder = new ContainerBuilder();
            loggerBuilder.RegisterModule(new LoggerContainer());
            AppContainer.UpdateContainer(loggerBuilder);
            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(AppContainer.Current);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
