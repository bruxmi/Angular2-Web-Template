using Autofac;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace Presentation.Web.Api.Base
{
    public class BaseApiController<TBusinessService, TMappingService> : ApiController
    {

        protected const string ApiRouteBase = "api/";
        public BaseApiController()
            : this(
                AppContainer.Current.Resolve<TBusinessService>(),
                AppContainer.Current.Resolve<TMappingService>())
        {
        }
        public BaseApiController(TBusinessService businessService, TMappingService mappingService)
        {
            if (businessService == null)
            {
                throw new ArgumentNullException(nameof(businessService));
            }
            if (mappingService == null)
            {
                throw new ArgumentNullException(nameof(mappingService));
            }

            this.BusinessService = businessService;
            this.MappingService = mappingService;
        }

        protected TBusinessService BusinessService { get; }
        protected TMappingService MappingService { get; }

    }
}