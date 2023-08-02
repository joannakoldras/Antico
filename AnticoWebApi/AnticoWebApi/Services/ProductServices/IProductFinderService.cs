using AnticoWebApi.DataWrappers;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ProductServices
{
    public interface IProductFinderService
    {
        public DataResult GetAllProducts();
        public DataResult GetProductsByCategory(string category);

        public DataResult FindProducts(string searchString);
    }
}
