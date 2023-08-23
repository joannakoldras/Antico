using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Services.UserServices
{
    public interface IRegisterService
    {
        DataResult RegisterUser(UserViewModel userVM); 
    }
}
