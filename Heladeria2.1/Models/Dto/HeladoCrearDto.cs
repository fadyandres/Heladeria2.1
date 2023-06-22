using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class HeladoCrearDto
    {
        [Required]
        public int IdHelado { get; set; }
        [Required]
        public string? NombreHelado { get; set; }
        [Required]
        public decimal CantidadHelado { get; set; }
        [Required]
        public decimal PrecioHelado { get; set; }
    }
}
