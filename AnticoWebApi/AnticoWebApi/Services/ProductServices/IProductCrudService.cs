using AnticoWebApi.DataWrappers;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ProductServices
{
    public interface IProductCrudService
    {
        DataResult AddProductToDb(ProductViewModel productVM);
        DataResult UpdateProductInDb(ProductViewModel productVM);
        DataResult DeleteProductFromDb(ProductViewModel productVM);
    }
}
