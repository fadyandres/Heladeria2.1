using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HeladeriaAPI.Models
{
    public class Ventas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVentas { get; set; }
        public decimal IngresosDeVenta { get; set; }
        public int IdHelado { get; set; }
        public string? NombreHelado { get; set; }
        [ForeignKey("IdHelado")]
        public Helado helado { get; set; }
        public int IdToppings { get; set; }
        public string? Topping { get; set; }
        [ForeignKey("IdToppings")]
        public Toppings toppings { get; set; }

    }
}
