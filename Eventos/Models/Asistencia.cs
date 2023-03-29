using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Asistencia")]
    public class Asistencia
    {
        [Key]
        public int Id_Asistencia { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string Estado { get; set; }
    }
}
