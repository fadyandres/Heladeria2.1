using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HeladeriaAPI.Models
{
    public class Toppings
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdToppings { get; set; }
        [Required]
        [StringLength(50)]
        public string? Topping { get; set; }
        public int CantidadToppings { get; set; }
        public decimal PrecioTopping { get; set; }
    }
}
