using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Pareja")]
    public class Pareja
    {
        [Key]
        public int Id_Pareja { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
    }
}
