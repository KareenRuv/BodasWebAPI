using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Eventos.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        public int Id_Menu { get; set; }
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string MenuName { get; set; }
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string Descripcion { get; set; }
    }
}
