using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Invitados")]
    public class Invitados
    {
        [Key]
        public int Id_Invitados { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Nombre { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ApellidoPaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string ApellidoMaterno { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public int Id_Sexo { get; set; }
        public int Id_Edad { get; set; }
        public string Telefono { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public int Id_Asistencia { get; set; }
        public int Id_Menu { get; set; }
        
    }
}
