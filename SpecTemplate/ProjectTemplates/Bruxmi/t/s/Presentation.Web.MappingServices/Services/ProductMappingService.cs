using Core.Entities;
using Presentation.Web.MappingServices.Interfaces.Base;
using Presentation.Web.ViewModels.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Web.MappingServices.Services
{
    public class ProductMappingService : IMappingGetService<Product, ProductGetVm>
    {
        public async Task<ProductGetVm> EntityToGetVmAsync(Product entity)
        {
            return await Task.FromResult(
                new ProductGetVm {
                    description = entity.description,
                    Id = entity.Id,
                    imageUrl = entity.imageUrl,
                    price = entity.price,
                    productCode = entity.productCode,
                    productName = entity.productName,
                    releaseDate = entity.releaseDate,
                    starRating = entity.starRating
                });
        }

        public async Task<List<ProductGetVm>> EntityToGetVmAsync(List<Product> entities)
        {
            var result = new List<ProductGetVm>();
            foreach (var entity in entities)
            {
                result.Add(await this.EntityToGetVmAsync(entity));
            }
            return result;
        }
    }
}
