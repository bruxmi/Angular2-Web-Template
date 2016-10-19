using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services.Query
{
    public interface IProductQueryService
    {
        Task<List<Product>> GetProductsAsync();

        Task<Product> GetProductByIdAsync(int productId);

    }
}
