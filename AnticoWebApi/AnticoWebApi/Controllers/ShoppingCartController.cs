using AnticoWebApi.DataWrappers;
using AnticoWebApi.Services.ShoppingCartServices;
using AnticoWebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnticoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private IShoppingCartService _shoppingCartService { get; set; }
        
        public ShoppingCartController()
        {
            _shoppingCartService = new ShoppingCartService(); 
        }

        [HttpPost("Products")]
        public DataResult AddProductToShoppingCart(ProductViewModel product)
        {
            return _shoppingCartService.AddProductToShoppingCart(product);
        }

        [HttpGet("Products")]
        public DataResult GetAllProductsFromShoppingCart()
        {
            return _shoppingCartService.GetAllProductsFromShoppingCart(); 
        }

        [HttpDelete("Products")]
        public DataResult DeleteProductFromShoppingCart(ProductViewModel product)
        {
            return _shoppingCartService.DeleteProductFromShoppingCart(product); 
        }
    }
}
