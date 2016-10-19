using Autofac;
using Business;
using Core.Interfaces.Services.Query;

namespace Core.Registration.Container
{
    public class ProductContainer: Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductQueryService>().As<IProductQueryService>().InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
