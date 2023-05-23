﻿using AnticoWebApi.DbConnection;
using AnticoWebApi.DbModels;
using AnticoWebApi.Mappers;
using AnticoWebApi.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AnticoWebApi.Services
{
    public class ProductFinderService : IProductFinderService
    {
        public IEnumerable<ProductViewModel> GetAllProducts() 
        {
            IEnumerable<Product> dbProducts;
            //var optionsBuilder = new DbContextOptionsBuilder<AnticoDbContext>();
            //optionsBuilder.UseSqlServer();
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
    }
}