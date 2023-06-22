using HeladeriaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Heladeria2._1.DatosPerrones
{
    public class HeladeriaContext : DbContext
    {
        public HeladeriaContext(DbContextOptions<HeladeriaContext> options ) : base(options)
        {

        }

        public DbSet<Helado> Heladoss { get; set; }
        public DbSet<Toppings> Toppingss { get; set; }
        public DbSet<Ventas> Ventass { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Helado>().HasData(

                new Helado ()
                {
                    IdHelado=1,
                    NombreHelado = "Chocolate",
                    CantidadHelado = 30.8M,
                    PrecioHelado = 43.6M
                },
                new Helado()
                {
                    IdHelado = 2,
                    NombreHelado ="Fresa",
                    CantidadHelado=42.6M,
                    PrecioHelado=39.99M
                },
                new Helado()
                {
                    IdHelado = 3,
                    NombreHelado = "Vainilla",
                    CantidadHelado= 24.5M,
                    PrecioHelado=38.50M
                });

            modelBuilder.Entity<Toppings>().HasData(
                
                new Toppings()
                {
                    IdToppings=1,
                    Topping="Galletas Oreo",
                    CantidadToppings=36,
                    PrecioTopping = 13.62M
                },
                new Toppings()
                {
                    IdToppings=2,
                    Topping="Barquillos de valinilla",
                    CantidadToppings=20 ,
                    PrecioTopping= 3.9M
                },
                new Toppings()
                {
                    IdToppings=3,
                    Topping= "Chispitas",
                    CantidadToppings= 25,
                    PrecioTopping= 6.25M
                },
                new Toppings()
                {
                    IdToppings=4,
                    Topping="Fresitas",
                    CantidadToppings=14,
                    PrecioTopping=13.45M
                });





        }
    }                       
}