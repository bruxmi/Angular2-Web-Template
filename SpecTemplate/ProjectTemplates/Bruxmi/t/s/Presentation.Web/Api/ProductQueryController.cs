using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace Angular2.Api
{
    public class ProductQueryController : ApiController
    {
        private readonly List<Product> productList;
        public ProductQueryController()
        {
            productList = new List<Product>
            {
                new Product
                {
                    imageUrl = "http://openclipart.org/image/300px/svg_to_png/26215/Anonymous_Leaf_Rake.png",
                    description = "Leaf rake with 48-inch wooden handle.",
                    price = 19.54m,
                    productCode = "GDN-0011",
                    productId = 1,
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
                    productId = 2,
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
                    productId = 3,
                    productName = "Hammer",
                    releaseDate = new DateTime(),
                    starRating = 2.51m
                }
            };
        }

        public async Task<IHttpActionResult> GetProducts()
        {
            return Ok(await Task.FromResult(productList));
        }
        public async Task<IHttpActionResult> GetProductById(int id)
        {
            return Ok(await Task.FromResult(productList.FirstOrDefault(a => a.productId == id)));
        }
    }

    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productCode { get; set; }
        public DateTime releaseDate { get; set; }
        public decimal price { get; set; }
        public string description { get; set; }
        public decimal starRating { get; set; }
        public string imageUrl { get; set; }
    }
}
