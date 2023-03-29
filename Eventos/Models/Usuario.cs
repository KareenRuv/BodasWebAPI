using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id_Usuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(30")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Email { get; set; }
    }
}
