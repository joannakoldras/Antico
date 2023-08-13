using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;

namespace AnticoWebApi.Repository
{
    public interface IProductRepository
    {
        DataResult AddProduct(Product product);
        DataResult UpdateProduct(Product product);
        DataResult DeleteProduct(Product product);
    }
}
