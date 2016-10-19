using Autofac;
using Core;
using Core.Interfaces.Services;
using Microsoft.Owin;
using Owin;
using Presentation.Web.Extensions;
using System;

[assembly: OwinStartup(typeof(Presentation.Web.StartUp))]
namespace Presentation.Web
{
    public class StartUp
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
                // Creates a unique ID per request to ease maintenance ('Correlation ID')
                app.UseRequestId();
            }

            catch (Exception exception)
            {
                AppContainer.Current.Resolve<IExceptionHandlerService>().Handle(exception);
                throw;
            }
        }
    }
}