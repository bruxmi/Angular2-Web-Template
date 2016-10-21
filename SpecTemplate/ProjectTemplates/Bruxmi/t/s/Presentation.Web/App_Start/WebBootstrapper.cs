using Autofac;
using Core.Entities;
using Core.Entities.Application;
using Presentation.Web.MappingServices.Interfaces.Base;
using Presentation.Web.MappingServices.Services;
using Presentation.Web.ViewModels.Log;
using Presentation.Web.ViewModels.Product;

namespace Presentation.Web.App_Start
{
    public static class WebBootstrapper
    {
        public static void InitializeProduction(ContainerBuilder builder) {
            //Register BusinessServices
            Core.Registration.Bootstrapper.InitializeProduction(builder);

            //Register MappingServices
            builder.RegisterType<LogMappingService>().As<IMappingGetService<Log, LogGetVm>>().InstancePerLifetimeScope();
            builder.RegisterType<ProductMappingService>().As<IMappingGetService<Product, ProductGetVm>>().InstancePerLifetimeScope();
        }
    }
}