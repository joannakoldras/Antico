using AnticoWebApi.DataWrappers;
using AnticoWebApi.DomainModels;
using AnticoWebApi.Mappers;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.ShoppingCartServices
{
    public class ShoppingCartService : IShoppingCartService 
    {
        private ShoppingCart shoppingCart { get; set; } 

        public ShoppingCartService()
        {
            shoppingCart = new ShoppingCart(); 
        }

        public DataResult AddProductToShoppingCart(ProductViewModel productVM) 
        {
            try
            {
                var product = productVM.ToProductDbModel();
                shoppingCart.AddToShoppingCart(product);
                return new DataResult(true, "Successfully added to cart");
            }
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message);
            }
        }

        public DataResult DeleteProductFromShoppingCart(ProductViewModel productVM)
        {
            try
            {
                var product = productVM.ToProductDbModel();
                var isDeleted = shoppingCart.DeleteFromShoppingCart(product);
                return isDeleted == true ? 
                    new DataResult(isDeleted, "Successfully deleted") :
                    new DataResult(isDeleted, "Product wasn't deleted from shopping cart");  

            }
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message); 
            }
        }

        public DataResult GetAllProductsFromShoppingCart()
        {
            try
            {
                var products = shoppingCart.GetAllProducts();
                return new DataResult(true, products, "Data returned successfully");
            }
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message); 
            }
        }
    }
}
