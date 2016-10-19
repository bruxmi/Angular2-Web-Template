using Autofac;
using Core.Interfaces.Repository.Query;
using Data.Repository.Query;

namespace Core.Registration.Container
{
    public class GenericRepositoryContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(QueryRepository<>)).As(typeof(IQueryRepository<>)).InstancePerLifetimeScope();
            base.Load(builder);
        }
    }
}
