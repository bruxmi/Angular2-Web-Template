using Core.Interfaces.Services.Query;
using Presentation.Web.Api.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class ProductQueryController : BaseApiController<IProductQueryService>
    {
        public async Task<IHttpActionResult> GetProducts()
        {
            return Ok(await this.Service.GetProductsAsync());
        }
        public async Task<IHttpActionResult> GetProductById(int id)
        {
            return Ok(await this.Service.GetProductByIdAsync(id));
        }
    }
}
