using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnticoWebApi.DbModels
{
    [Table("Products")]
    public class Product
    {
        [Column("ProductId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoinkrementacja 
        [Required]
        public int Id { get; set; }

        [StringLength(50)]  
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [NotMapped] 
        public virtual ProductCategory Id_CategoryId { get; set; }  

        public bool IsAvaliable { get; set; }
        
        public string FilePathPhoto { get; set; }
        
        public double Price { get; set; }  
    }
}
