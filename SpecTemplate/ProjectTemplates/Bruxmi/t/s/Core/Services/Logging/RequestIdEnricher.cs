using Autofac;
using Core.Constants;
using Core.Interfaces.Services.Query;
using Serilog.Core;
using Serilog.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Logging
{
    public class RequestIdEnricher : ILogEventEnricher
    {
        public const string RequestIdProperty = LogConfigurationNames.REQUEST_ID_PARAMETER;
        private LogEventProperty cachedRequestId;

        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {

            this.cachedRequestId = propertyFactory.CreateProperty(RequestIdProperty, this.GetRequestId());
            logEvent.AddOrUpdateProperty(cachedRequestId);
        }

        private string GetRequestId()
        {
            var contextService = AppContainer.Current.Resolve<IContextService>();
            var result = contextService.RequestId ?? string.Empty;
            return result;
        }
    }
}
