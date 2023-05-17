using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnticoWebApi.DbModels
{
    [Table("ProductCategories")]
    public class ProductCategory
    {
        [Column("CategoryId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoinkrementacja 
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; } 
    }
}
