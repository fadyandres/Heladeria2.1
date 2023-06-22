using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeladeriaAPI.Models
{
    public class Helado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdHelado { get; set; }
        [Required]
        public string? NombreHelado { get; set; }

        public decimal CantidadHelado { get; set; }

        public decimal PrecioHelado { get; set; }
    }
}
