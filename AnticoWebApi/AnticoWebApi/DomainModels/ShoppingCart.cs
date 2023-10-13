using AnticoWebApi.DbModels;
using AnticoWebApi.Session;

namespace AnticoWebApi.DomainModels
{
    public class ShoppingCart
    {
        private List<Product> products { get; set; } 
        private SessionHelper sessionHelper { get; set; } 
        public ShoppingCart()
        {
            this.products = new List<Product>();
            this.sessionHelper = new SessionHelper(); 
        }

        public void AddToShoppingCart(Product product)
        {
            sessionHelper.SetSessionWithValue(product); 
        }

        public bool DeleteFromShoppingCart(Product product)
        {
            var item = FindProductInShoppingCartById(product); 
            if(item != null)
            {
                this.products.Remove(item);
                return true;
            }
            return false; 
        }

        public Product FindProductInShoppingCartById(Product product)
        {
            var item = products.Find(x => x.Id == product.Id);
            return item; 
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products; 
        }
    }
}
