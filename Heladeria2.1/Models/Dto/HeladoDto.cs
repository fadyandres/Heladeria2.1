using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models.Dto
{
    public class HeladoDto
    {
        [Required]
        public int IdHelado { get; set; }
        [Required]
        public string? NombreHelado { get; set; }

        public decimal CantidadHelado { get; set; }

        public decimal PrecioHelado { get; set; }
    }
}
