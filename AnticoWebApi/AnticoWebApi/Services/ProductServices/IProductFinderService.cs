using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ProductServices
{
    public interface IProductFinderService
    {
        public IEnumerable<ProductViewModel> GetAllProducts();
        public IEnumerable<ProductViewModel> GetProductsByCategory(string category);

        public IEnumerable<ProductViewModel> FindProducts(string searchString);
    }
}
