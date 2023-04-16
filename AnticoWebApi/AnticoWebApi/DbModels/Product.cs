namespace AnticoWebApi.DbModels
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }  
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public bool IsAvaliable { get; set; }
        public string FilePathPhoto { get; set; }
        public double Price { get; set; }  
    }
}
