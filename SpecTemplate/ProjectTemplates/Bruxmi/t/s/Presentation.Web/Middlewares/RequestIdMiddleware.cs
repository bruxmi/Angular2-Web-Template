using Autofac;
using Core;
using Core.Interfaces;
using Core.Interfaces.Services.Query;
using Microsoft.Owin;
using System;
using System.Threading.Tasks;

namespace Presentation.Web.Middlewares
{
    public class RequestIdMiddleware : OwinMiddleware
    {
        public RequestIdMiddleware(OwinMiddleware next)
            : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            var contextService = AppContainer.Current.Resolve<IContextService>();
            contextService.RequestId = Guid.NewGuid().ToString();

            var middleware = this.GetType().Name;
            var log = AppContainer.Current.Resolve<ILog>();
            log.Debug($"Handling request '{context?.Request?.Method} {context?.Request?.Uri}'...");
            log.Debug($"Invoking middleware '{middleware}'...");

            await this.Next.Invoke(context);
        }
    }

}