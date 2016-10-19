using Autofac;
using Core.Registration.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Registration
{
    public static class Bootstrapper
    {
        public static void InitializeProduction(ContainerBuilder builder)
        {
            builder.RegisterModule(new ApplicationSettingContainer());
            builder.RegisterModule(new MiscContainer());
            builder.RegisterModule(new GenericRepositoryContainer());
            builder.RegisterModule(new ProductContainer());
        }
    }
}
