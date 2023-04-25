using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AnticoWebApi.DbModels
{
    [Table("Users")]
    public class User
    {
        [Column("UserId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //autoinkrementacja 
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string EncryptedPassword { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }
    }
}
