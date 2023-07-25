using AnticoWebApi.ViewModels.Enums;

namespace AnticoWebApi.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public string Description { get; set; } 
        public ProductCategoryEnum Category { get; set; }  
        public bool IsAvaliable { get; set; }
        public string FilePathPhoto { get; set; }
        public double Price { get; set; } 
    }
}
