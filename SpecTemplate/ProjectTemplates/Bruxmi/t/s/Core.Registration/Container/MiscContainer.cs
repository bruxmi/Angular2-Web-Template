using Autofac;
using Core.Interfaces.Services;
using Core.Interfaces.Services.Query;
using Core.Services;

namespace Core.Registration.Container
{
    public class MiscContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppConfigurationService>().As<IAppConfigurationService>().InstancePerLifetimeScope();
            builder.RegisterType<ExceptionHandlerService>().As<IExceptionHandlerService>();
            builder.RegisterType<ContextService>().As<IContextService>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
