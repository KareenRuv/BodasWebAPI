using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Edades")]
    public class Edades
    {
        [Key]
        public int Id_Edad { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public String Edad { get; set; }
    }
}
