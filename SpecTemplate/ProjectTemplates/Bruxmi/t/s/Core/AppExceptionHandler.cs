using Core;
using Core.Interfaces.Services;
using Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class AppExceptionHandler
    {
        /// <summary>
        ///     Get the current exception handler.
        /// </summary>
        public static IExceptionHandlerService Current
            => Factory ?? (Factory = Create());

        /// <summary>
        /// Gets or sets the factory.
        /// </summary>
        public static IExceptionHandlerService Factory { private get; set; }

        public static IExceptionHandlerService Create()
        {
            return new ExceptionHandlerService(SerligLogger.Current);
        }
    }

}
