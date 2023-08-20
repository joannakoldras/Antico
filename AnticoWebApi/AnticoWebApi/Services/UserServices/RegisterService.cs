using AnticoWebApi.DataWrappers;
using AnticoWebApi.DbConnection;
using AnticoWebApi.DbModels;

namespace AnticoWebApi.Services.UserServices
{
    public class RegisterService : IRegisterService
    {
        public DataResult RegisterUser(User user)
        //przemapować user na UserViewModel 
        {
            using (var dbContext = new AnticoDbContext())
            {
                var dbUser = dbContext.Users.
                    Where(x => x.Email == user.Email &&
                    x.UserName == user.UserName &&
                    x.EncryptedPassword == user.EncryptedPassword).ToList();

                if (dbUser.Count() == 0)
                {
                    dbContext.Add(user);
                    dbContext.SaveChanges();
                }
                else return new DataResult(false, "User with passed data already exist");

                return new DataResult(true, "User successfully registered"); 
            }
        }
    }
}
