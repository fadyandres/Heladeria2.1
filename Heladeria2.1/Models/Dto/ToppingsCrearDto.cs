using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class ToppingsCrearDto
    {
        [Required]
        public int IdToppings { get; set; }
        [Required]
        [MaxLength(30)]
        public string? Topping { get; set; }
        [Required]
        public int CantidadToppings { get; set; }
        [Required]
        public decimal PrecioTopping { get; set; }
    }
}
