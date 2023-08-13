using AnticoWebApi.DataWrappers;
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

        public DataResult AddProductToDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.AddProduct(product);
            return result;
        }

        public DataResult UpdateProductInDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.UpdateProduct(product);
            return result;
        }

        public DataResult DeleteProductFromDb(ProductViewModel productVM)
        {
            var product = productVM.ToProductDbModel();
            var result = productRepository.DeleteProduct(product);
            return result;
        }
    }
}
