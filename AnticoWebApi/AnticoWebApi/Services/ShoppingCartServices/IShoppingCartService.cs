using AnticoWebApi.DataWrappers;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ShoppingCartServices
{
    public interface IShoppingCartService
    {
        DataResult AddProductToShoppingCart(ProductViewModel productVM);
        DataResult DeleteProductFromShoppingCart(ProductViewModel productVM);
        DataResult GetAllProductsFromShoppingCart(); 
    }
}
