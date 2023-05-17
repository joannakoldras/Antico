using AnticoWebApi.DbModels;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace AnticoWebApi.DbConnection
{
    public class AnticoDbContext : DbContext
    {
        public AnticoDbContext(DbContextOptions<AnticoDbContext> options) : base(options)
        {
            
        }

        public AnticoDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\\MSSQLLocalDB;database=AnticoDatabase;Trusted_Connection=True;");
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
