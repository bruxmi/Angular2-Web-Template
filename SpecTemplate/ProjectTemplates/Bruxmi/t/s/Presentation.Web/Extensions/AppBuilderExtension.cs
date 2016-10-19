using Autofac;
using Core;
using Core.Interfaces;
using Owin;
using Presentation.Web.Middlewares;

namespace Presentation.Web.Extensions
{
    public static class AppBuilderExtension
    {
        private static readonly ILog Logger = AppContainer.Current.Resolve<ILog>();

        public static void UseRequestId(this IAppBuilder app)
        {
            Logger.Info("Using request identifier.");

            app.Use<RequestIdMiddleware>();
        }
    }
}