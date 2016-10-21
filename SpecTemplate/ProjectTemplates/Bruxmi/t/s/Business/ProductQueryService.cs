using Core.Entities;
using Core.Interfaces.Services.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class ProductQueryService: IProductQueryService
    {
        private readonly List<Product> productList;

        public ProductQueryService()
        {
            productList = new List<Product>
            {
                new Product
                {
                    imageUrl = "http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png",
                    description = "Leaf rake with 48-inch wooden handle.",
                    price = 19.54m,
                    productCode = "GDN-0011",
                    Id = 1,
                    productName = "Leaf Rake",
                    releaseDate = new DateTime(),
                    starRating = 3.2m
                },
                new Product
                {
                    imageUrl = "http://openclipart.org/image/300px/svg_to_png/58471/garden_cart.png",
                    description = "15 gallon capacity rolling garden cart",
                    price = 32.99m,
                    productCode = "GDN-0023",
                    Id = 2,
                    productName = "Garden Cart",
                    releaseDate = new DateTime(),
                    starRating = 4.2m
                },
                new Product
                {
                    imageUrl = "http://openclipart.org/image/300px/svg_to_png/73/rejon_Hammer.png",
                    description = "Curved claw steel hammer",
                    price = 8.56m,
                    productCode = "TBX-0048",
                    Id = 3,
                    productName = "Hammer",
                    releaseDate = new DateTime(),
                    starRating = 2.51m
                }
            };
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await Task.FromResult(productList.FirstOrDefault(a => a.Id == productId));      
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await Task.FromResult(productList);        
        }
    }
}
