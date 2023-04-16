namespace AnticoWebApi.DbModels
{
    public class User
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Surname { get; set; }
        public string Email { get; set; }
        public string EncryptedPassword { get; set; } 
        public string UserName { get; set; }
    }
}
