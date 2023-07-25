using AnticoWebApi.DbModels;

namespace AnticoWebApi.Repository
{
    public interface IProductRepository
    {
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(Product product);
    }
}
