using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Proveedores")]
    public class Proveedores
    {
        [Key]
        public int Id_Proveedor { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Nombre_Proveedor { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Servicio { get; set; }
        [Required]
        [Column(TypeName = "varchar(12)")]
        public String Telefono { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string EstadoServicio { get; set; }

    }
}
