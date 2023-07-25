using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ProductServices
{
    public interface IProductCrudService
    {
        bool AddProductToDb(ProductViewModel productVM);
        bool UpdateProductInDb(ProductViewModel productVM);
        bool DeleteProductFromDb(ProductViewModel productVM);
    }
}
