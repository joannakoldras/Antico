using AnticoWebApi.DbConnection;
using AnticoWebApi.DbModels;
using AnticoWebApi.Mappers;
using AnticoWebApi.ViewModels;
using FluentAssertions.Common;
using Microsoft.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AnticoWebApi.Services
{
    public class ProductFinderService : IProductFinderService
    {
        public IEnumerable<ProductViewModel> GetAllProducts() 
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
            return vMProducts; 
        }

        public IEnumerable<ProductViewModel> GetProductsByCategory(string category)
        {
            IEnumerable<Product> dbCategoryProducts; 
            using (var db = new AnticoDbContext())
            {
                var dbCategory = db.ProductCategories.FirstOrDefault(x => x.Name.ToLower() == category.ToLower());
                dbCategoryProducts = db.Products.Where(x => x.CategoryId == dbCategory.Id).ToList(); 

            }
            var vMProducts = new List<ProductViewModel>();

            foreach (var item in dbCategoryProducts)
            {
                var vMProduct = item.ToProductViewModel();
                vMProducts.Add(vMProduct);
            }
            return vMProducts;
        }

        public IEnumerable<ProductViewModel> FindProducts(string searchString)
        {
            IEnumerable<Product> dbProducts;
            using (var db = new AnticoDbContext())
            {
                dbProducts = db.Products.Where(x => x.Description.ToLower().Contains(searchString.ToLower()) || 
                x.Name.ToLower().Contains(searchString.ToLower())).ToList();  
            }
            var vMProducts = new List<ProductViewModel>(); 
            
            foreach(var item in dbProducts)
            {
                var vMProduct = item.ToProductViewModel();
                vMProducts.Add(vMProduct);
            }

            return vMProducts; 
        }
    }
}
