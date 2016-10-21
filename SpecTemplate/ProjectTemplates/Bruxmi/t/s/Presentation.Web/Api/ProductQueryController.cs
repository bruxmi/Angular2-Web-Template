using Core.Entities;
using Core.Interfaces.Services.Query;
using Presentation.Web.Api.Base;
using Presentation.Web.MappingServices.Interfaces.Base;
using Presentation.Web.ViewModels.Product;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class ProductQueryController : BaseApiController<IProductQueryService, IMappingGetService<Product, ProductGetVm>>
    {
        public async Task<IHttpActionResult> GetProducts()
        {
            var entities = await this.BusinessService.GetProductsAsync();
            return Ok(await this.MappingService.EntityToGetVmAsync(entities));
        }
        public async Task<IHttpActionResult> GetProductById(int id)
        {
            var entity = await this.BusinessService.GetProductByIdAsync(id);
            return Ok(await this.MappingService.EntityToGetVmAsync(entity));
        }
    }
}
