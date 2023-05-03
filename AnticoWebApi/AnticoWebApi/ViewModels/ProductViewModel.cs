namespace AnticoWebApi.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; } 
        public string Description { get; set; } 
        public string Category { get; set; }  
        public bool IsAvaliable { get; set; }
        public string FilePathPhoto { get; set; }
        public double Price { get; set; } 
    }
}
