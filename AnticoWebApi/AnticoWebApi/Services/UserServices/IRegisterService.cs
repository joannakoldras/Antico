using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;

namespace AnticoWebApi.Services.UserServices
{
    public interface IRegisterService
    {
        DataResult RegisterUser(User user); 
    }
}
