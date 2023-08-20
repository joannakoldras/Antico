using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbModels;
using AnticoWebApi.Services.UserServices;
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
        public DataResult RegisterUser(User user)
        {
            return _registerService.RegisterUser(user);
        }
    }
}
