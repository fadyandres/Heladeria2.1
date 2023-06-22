using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class VentasDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public decimal IngresosDeVenta { get; set; }
        [Required]
        public int IdHelado { get; set; }
        [Required]
        public int IdToppings { get; set; }
    }
}
