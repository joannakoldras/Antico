using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;
using AnticoWebApi.Services.UserServices;
using AnticoWebApi.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnticoWebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public IRegisterService _registerService { get; set; }

        public UserController()
        {
            _registerService = new RegisterService();
        }

        [HttpPost("/Register")]
        public DataResult RegisterUser(UserViewModel userVM)
        {
            return _registerService.RegisterUser(userVM);
        }
    }
}
