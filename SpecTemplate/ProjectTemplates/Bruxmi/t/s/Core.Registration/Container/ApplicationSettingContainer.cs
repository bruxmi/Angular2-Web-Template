using Autofac;
using Business.ApplicationSettings;
using Core.Interfaces.Repository.Query;
using Core.Interfaces.Services.Query;
using Data.ApplicationSettingsContext;
using Data.Repository;
using Data.Repository.Query;

namespace Core.Registration.Container
{
    public class ApplicationSettingContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AppSettingContext>().InstancePerLifetimeScope();
            builder.RegisterType<ApplicationSettingQueryService>().As<IApplicationSettingQueryService>().InstancePerLifetimeScope();
            builder.RegisterType<ConnectionStringQueryService>().As<IConnectionStringQueryService>().InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(RepositoryApplicationSettingsInitializer<>)).As(typeof(IRepositoryApplicationSettingInitializer<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(ApplicationSettingsQueryRepository<>)).As(typeof(IApplicationSettingsQueryRepository<>)).InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
