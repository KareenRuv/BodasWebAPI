using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Boda")]
    public class Boda
    {
        [Key]
        public int Id_Boda { get; set; }
        [Required]
        public int Id_Usuario { get; set; }
        [Required]
        public int Id_Pareja { get; set; }
        [Required]
        [Column(TypeName = "varchar(15)")]
        public string Fecha { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Hora { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Lugar { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string Presupuesto { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string NumInvitados { get; set; }
    }
}
