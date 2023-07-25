using AnticoWebApi.DbConnection;
using AnticoWebApi.DbModels;

namespace AnticoWebApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        public bool AddProduct(Product product)
        {
            try
            {
                using (var db = new AnticoDbContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges(); 
                }
                return true;
            }
            catch (Exception exception)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                using (var db = new AnticoDbContext())
                {
                    var item = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
                    if (item != null)
                    {
                        item.Price = product.Price;
                        item.FilePathPhoto = product.FilePathPhoto;
                        item.Name = product.Name;
                        item.Description = product.Description;
                        item.CategoryId = product.CategoryId;   
                        db.SaveChanges();
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception exception)
            {
                return false;
            }
            return true;

        }

        public bool DeleteProduct(Product product)
        {
            using (var db = new AnticoDbContext())
            {
                var item = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
                if (item != null)
                {
                    db.Products.Remove(item);
                    db.SaveChanges();
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
