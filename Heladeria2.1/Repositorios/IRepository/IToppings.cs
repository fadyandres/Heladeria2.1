using HeladeriaAPI.Models;
namespace Heladeria2._1.Repositorios.IRepository
{
    public interface IToppings:IRepository<Toppings>
    {
        Task<Toppings> Update(Toppings entity);

    }
}
