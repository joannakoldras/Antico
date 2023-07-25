using AnticoWebApi.Mappers;
using AnticoWebApi.Repository;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ProductServices
{
    public class ProductCrudService : IProductCrudService
    {
        private IProductRepository productRepository { get; set; }
        public ProductCrudService()
        {
            productRepository = new ProductRepository();
        }

        public bool AddProductToDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.AddProduct(product);
            return result;
        }

        public bool UpdateProductInDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.UpdateProduct(product);
            return result;
        }

        public bool DeleteProductFromDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.DeleteProduct(product);
            return result;
        }
    }
}
