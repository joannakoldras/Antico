using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services
{
    public interface IProductFinderService
    {
        public IEnumerable<ProductViewModel> GetAllProducts();
        public IEnumerable<ProductViewModel> GetProductsByCategory(string category);
    }
}
