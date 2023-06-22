using HeladeriaAPI.Models;

namespace Heladeria2._1.Repositorios.IRepository
{
    public interface IHelados : IRepository <Helado>
    {
        Task<Helado> Update(Helado entity);
    }
}
