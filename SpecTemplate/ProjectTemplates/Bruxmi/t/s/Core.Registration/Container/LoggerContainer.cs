using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Registration.Container
{
    public class LoggerContainer : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterInstance(SerligLogger.Current);
            base.Load(builder);
        }
    }
}
