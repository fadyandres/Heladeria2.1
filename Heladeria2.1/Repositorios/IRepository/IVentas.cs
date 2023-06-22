using HeladeriaAPI.Models;

namespace Heladeria2._1.Repositorios.IRepository
{
    public interface IVentas : IRepository <Ventas>
    {
        Task<Ventas> Update(Ventas entity);
    }
}
