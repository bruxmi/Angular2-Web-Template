using Core.Exceptions;
using Core.Extensions;
using Core.Interfaces;
using Core.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace Core.Services
{
    public class ExceptionHandlerService : IExceptionHandlerService
    {
        private readonly ILog log;

        public ExceptionHandlerService(ILog log)
        {
            this.log = log;
        }

        public Task Handle(Exception exception)
        {
            var message = exception.FlattenedMessage();
            if (exception is BaseAppException)
            {
                this.log.Warn(message);
            }
            else
            {
                this.log.Error(message, exception);
            }

            return Task.FromResult(0);
        }
    }
}
