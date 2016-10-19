﻿using Core.Extensions;
using Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.ExceptionHandling;

namespace Presentation.Web.ExceptionHandler
{
    public class AppExceptionLogger : ExceptionLogger
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AppExceptionLogger" /> class.
        /// </summary>
        /// <param name="exceptionHandlerService">The exception handling service.</param>
        public AppExceptionLogger(IExceptionHandlerService exceptionHandlerService)
        {
            this.ExceptionHandlerService = exceptionHandlerService;
        }

        /// <summary>
        ///     Gets the logger.
        /// </summary>
        private IExceptionHandlerService ExceptionHandlerService { get; }

        /// <summary>
        ///     Logs the exception synchronously.
        /// </summary>
        /// <param name="context">The context.</param>
        public override void Log(ExceptionLoggerContext context)
        {
            var exception = context.Exception;
            this.ExceptionHandlerService.Handle(exception);
            exception.Rethrow();
        }
    }

}