using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace AnticoWebApi.Session
{
    public class SessionHelper : ControllerBase 
    {
        private IHttpContextAccessor httpContextAccessor;
        public SessionHelper()
        {
            httpContextAccessor = new HttpContextAccessor();
        }
        public void SetSessionWithValue(object value)
        {
            SetObjectAsJson("1", value); 
        }
        private void SetObjectAsJson(string key, object value)
        {
            httpContextAccessor.HttpContext.Session.SetString(JsonConvert.SerializeObject(value), JsonConvert.SerializeObject(value));
        }

        private T GetObjectFromJson<T>(string key)
        {
            var value = httpContextAccessor.HttpContext.Session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);

        }
    }
}
