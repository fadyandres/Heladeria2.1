using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class VentasUpdateDto
    {
        [Required]
        public int IdVentas { get; set; }
        [Required]
        public decimal IngresosDeVenta { get; set; }
        [Required]
        public int IdHelado { get; set; }
        [Required]
        public int IdToppings { get; set; }
    }
}
