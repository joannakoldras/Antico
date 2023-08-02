using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;
using AnticoWebApi.Services;
using AnticoWebApi.Services.ProductServices;
using AnticoWebApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AnticoWebApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductFinderService _productFinderService { get; set; }
        private IProductCrudService _productCrudService { get; set; }
        public ProductsController()
        {
            _productFinderService = new ProductFinderService();
            _productCrudService = new ProductCrudService();
        }

        [HttpGet(Name = "Products")]
        public DataResult GetAllProducts()
        {
            return _productFinderService.GetAllProducts();
        }

        [HttpGet("{searchString}")]
        public DataResult FindProducts(string searchString)
        {
            return _productFinderService.FindProducts(searchString);
        }

        [HttpGet("Categories/{category}")]
        public DataResult GetProductsByCategory(string category)
        {
            return _productFinderService.GetProductsByCategory(category); 
        }

        [HttpPost]
        public bool AddProduct(ProductViewModel product)
        {
            return _productCrudService.AddProductToDb(product);
        }

        [HttpPut]
        public bool UpdateProduct(ProductViewModel product)
        {
            return _productCrudService.UpdateProductInDb(product);
        }

        [HttpDelete]
        public bool DeleteProduct(ProductViewModel product)
        {
            return _productCrudService.DeleteProductFromDb(product); 
        }
    }
}
