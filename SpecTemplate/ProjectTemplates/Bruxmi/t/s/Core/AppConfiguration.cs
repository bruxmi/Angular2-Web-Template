using Autofac;
using Core.Interfaces.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class AppConfiguration
    {
        /// <summary>
        ///     Get the current configuration.
        /// </summary>
        public static IAppConfigurationService Current
            => Factory ?? (Factory = AppContainer.Current.Resolve<IAppConfigurationService>());

        /// <summary>
        /// Gets or sets the factory.
        /// </summary>
        public static IAppConfigurationService Factory { private get; set; }
    }
}
