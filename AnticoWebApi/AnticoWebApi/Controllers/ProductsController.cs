using AnticoWebApi.DbModels;
using Microsoft.AspNetCore.Mvc;

namespace AnticoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet(Name = "Products")]
        public IEnumerable<Product> GetAllProducts()
        {
            return new List <Product>()
            {

            }; 
        }
    }
}
