using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbConnection;
using AnticoWebApi.DbModels;
using AnticoWebApi.Mappers;
using AnticoWebApi.ViewModels;
using FluentAssertions.Common;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnticoWebApi.Services.ProductServices
{
    public class ProductFinderService : IProductFinderService
    {
        public DataResult GetAllProducts()
        {
            try
            {

                IEnumerable<Product> dbProducts;
                using (var db = new AnticoDbContext())
                {
                    dbProducts = db.Products.ToList();
                }

                var vMProducts = new List<ProductViewModel>();

                foreach (var item in dbProducts)
                {
                    var vMProduct = item.ToProductViewModel();
                    vMProducts.Add(vMProduct);
                }

                return new DataResult(true, vMProducts);
            }
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message); 
            }
        }

        public DataResult GetProductsByCategory(string category)
        {
            try
            {
                IEnumerable<Product> dbCategoryProducts = new List<Product>();
                using (var db = new AnticoDbContext())
                {
                    var dbCategory = db.ProductCategories.FirstOrDefault(x => x.Name.ToLower() == category.ToLower());
                    if (dbCategory != null)
                        dbCategoryProducts = db.Products.Where(x => x.CategoryId == dbCategory.Id).ToList();
                    else
                        return new DataResult(false, "no category found"); 
                }
                var vMProducts = new List<ProductViewModel>();

                if(dbCategoryProducts.ToList().Count == 0)
                    return new DataResult(true, "no data found");

                foreach (var item in dbCategoryProducts)
                {
                    var vMProduct = item.ToProductViewModel();
                    vMProducts.Add(vMProduct);
                }
                return new DataResult(true, vMProducts);
            } 
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message); 
            }
        }

        public DataResult FindProducts(string searchString)
        {
            try 
            { 
                IEnumerable<Product> dbProducts;
                using (var db = new AnticoDbContext())
                {
                    dbProducts = db.Products.Where(x => x.Description.ToLower().Contains(searchString.ToLower()) ||
                    x.Name.ToLower().Contains(searchString.ToLower())).ToList();
                }
                var vMProducts = new List<ProductViewModel>();

                if (dbProducts.ToList().Count == 0)
                    return new DataResult(true, vMProducts, "no data found"); 

                foreach (var item in dbProducts)
                {
                    var vMProduct = item.ToProductViewModel();
                    vMProducts.Add(vMProduct);
                }

                return new DataResult(true, vMProducts); 
            }
            catch(Exception ex)
            {
                return new DataResult(false, ex.Message); 
            }
        }

        public IEnumerable<ProductViewModel> FindProductsByCategory(string category)
        {
            IEnumerable<Product> dbProducts;
            using (var db = new AnticoDbContext())
            {
                var categoryFromDb = db.ProductCategories.Where(x => x.Name.ToLower() == category.ToLower()).FirstOrDefault();
                dbProducts = db.Products.Where(x => x.CategoryId == categoryFromDb.Id);
            }
            var vMProducts = new List<ProductViewModel>();

            foreach (var item in dbProducts)
            {
                var vMProduct = item.ToProductViewModel();
                vMProducts.Add(vMProduct);
            }

            return vMProducts;
        }
    }
}
