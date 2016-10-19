using Autofac;
using Core;
using Core.Interfaces.Services;
using Presentation.Web.ExceptionHandler;
using System.Web.Http;

namespace Presentation.Web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.ConfigureExceptionHandling(AppContainer.Current.Resolve<IExceptionHandlerService>());
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
