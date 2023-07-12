using AnticoWebApi.DbModels;
using AnticoWebApi.Services;
using AnticoWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AnticoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductFinderService _productFinderService { get; set; }
        public ProductsController()
        {
            _productFinderService = new ProductFinderService();
        }

        [HttpGet(Name = "Products")]
        public IEnumerable<ProductViewModel> GetAllProducts()
        {
            return _productFinderService.GetAllProducts();
        }

        [HttpGet("{searchString}")]
        public IEnumerable<ProductViewModel> FindProducts(string searchString)
        {
            return _productFinderService.FindProducts(searchString);
        }

        [HttpGet("Categories/{category}")]
        public IEnumerable<ProductViewModel> GetProductsByCategory(string category)
        {
            return _productFinderService.GetProductsByCategory(category); 
        }
    }
}
