using Core.Constants;
using Core.Interfaces;
using Core.Services.Logging;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System.Collections.Generic;
using System.Data;

namespace Core
{
    public static class SerligLogger
    {
        /// <summary>
        ///     Gets the current instance of the logger.
        /// </summary>
        public static ILog Current
            => Factory ?? (Factory = Create());

        /// <summary>
        ///     Gets or sets the factory.
        /// </summary>
        public static ILog Factory { private get; set; }

        public static ILog Create()
        {
            var config = new LoggerConfiguration();
            config = config.MinimumLevel.Debug().
            Enrich.FromLogContext().
            Enrich.With(new UserNameEnricher()).
            Enrich.With(new RequestIdEnricher());

            var columns = new ColumnOptions
            {
                AdditionalDataColumns = new List<DataColumn>
                {
                    new DataColumn { DataType = typeof(string), ColumnName = UserNameEnricher.UserNameProperty},
                    new DataColumn { DataType = typeof(string), ColumnName = LogConfigurationNames.REQUEST_ID_PARAMETER},
                }
            };

            columns.Store.Remove(StandardColumn.Properties);
            config.WriteTo.MSSqlServer(
                connectionString: AppConfiguration.Current.ApplicationConnectionString,
                tableName: typeof(Core.Entities.Application.Log).Name,
                columnOptions: columns,
                restrictedToMinimumLevel: Serilog.Events.LogEventLevel.Debug);

            return new SerilogAdapter(config.CreateLogger());
        }
    }

}
