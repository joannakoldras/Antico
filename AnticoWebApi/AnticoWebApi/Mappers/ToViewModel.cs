using AnticoWebApi.DbModels;
using AnticoWebApi.ViewModels;
using System.Runtime.CompilerServices;

namespace AnticoWebApi.Mappers
{
    public static class ToViewModel
    {
        public static ProductViewModel ToProductViewModel(this Product product)
        {
            var productVM = new ProductViewModel(); 
            productVM.Name = product.Name; 
            productVM.Description = product.Description;
            //productVM.Category = product.Category; mechanizm konwertowania string na enum
            productVM.IsAvaliable = product.IsAvaliable;
            productVM.FilePathPhoto = product.FilePathPhoto;
            productVM.Price = product.Price;

            return productVM; 
        }

        public static OrderViewModel ToOrderViewModel(this Order order)
        {
            var orderVM = new OrderViewModel();
            orderVM.OrderId = order.LongTextId;
            orderVM.UserId = order.UserId;
            orderVM.ProductId = order.ProductId;

            return orderVM; 
        }

        public static UserViewModel ToUserViewModel(this User user)
        {
            var userVM = new UserViewModel();
            userVM.Name = user.Name;
            userVM.Surname = user.Surname;
            userVM.Email = user.Email;
            //userVM.Password = user.; mechanizm hashowania hasla
            userVM.UserName = user.UserName;

            return userVM;
        }
    }
}
