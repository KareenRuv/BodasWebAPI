using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Sexo")]
    public class Sexo
    {
        [Key]
        public int Id_Sexo { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SexoName { get; set; }
    }
}
