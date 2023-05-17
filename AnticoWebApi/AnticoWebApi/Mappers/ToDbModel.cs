using AnticoWebApi.DbModels;
using AnticoWebApi.ViewModels;

namespace AnticoWebApi.Mappers
{
    public static class ToDbModel
    {
        public static Product ToProductDbModel(this ProductViewModel productViewModel)
        {
            var productDB = new Product(); 
            productDB.Name = productViewModel.Name;
            productDB.Description = productViewModel.Description;
            //brak mechanizmu do konwersji enum na int
            productDB.IsAvaliable = productViewModel.IsAvaliable;
            productDB.FilePathPhoto = productViewModel.FilePathPhoto;
            productDB.Price = productViewModel.Price; 

            return productDB; 
        }

        public static Order ToOrderDbModel(this OrderViewModel orderViewModel)
        {
            var orderDb = new Order();
            orderDb.LongTextId = orderViewModel.OrderId;
            orderDb.UserId = orderViewModel.UserId;
            orderDb.ProductId = orderViewModel.ProductId;

            return orderDb;
        }

        public static User ToUserDbModel(this UserViewModel user)
        {
            var userDb = new User();
            userDb.Name = user.Name;
            userDb.Surname = user.Surname;
            userDb.Email = user.Email;
            //userVM.Password = user.; mechanizm hashowania hasla
            userDb.UserName = user.UserName;

            return userDb;
        }
    }
}
