using Serilog.Core;
using Serilog.Events;
using System.Security.Principal;

namespace Core.Services.Logging
{
    public class UserNameEnricher : ILogEventEnricher
    {
        public const string UserNameProperty = "UserName";
        private LogEventProperty cachedUserName;
        public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
        {
            this.cachedUserName = this.cachedUserName ?? propertyFactory.CreateProperty(UserNameProperty, this.GetUserName());
            logEvent.AddPropertyIfAbsent(cachedUserName);
        }

        private string GetUserName()
        {
            return WindowsIdentity.GetCurrent().Name;
        }
    }
}
