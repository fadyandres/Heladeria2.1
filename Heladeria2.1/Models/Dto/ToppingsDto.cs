using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class ToppingsDto
    {
        [Required]
        public int IdToppings { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Topping { get; set; }
        public int CantidadToppings { get; set; }
        public decimal PrecioTopping { get; set; }
    }
}
