using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Presentation.Web.ExceptionHandler
{
    public static class HttpConfigurationExtensions
    {
        public static HttpConfiguration ConfigureExceptionHandling(this HttpConfiguration httpConfiguration, IExceptionHandlerService exceptionHandlerService)
        {
            httpConfiguration.Services.Add(typeof(IExceptionLogger), new AppExceptionLogger(exceptionHandlerService));

            return httpConfiguration;
        }
    }
}