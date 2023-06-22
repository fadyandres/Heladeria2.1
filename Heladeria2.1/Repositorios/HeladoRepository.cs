using Heladeria2._1.DatosPerrones;
using Heladeria2._1.Repositorios.IRepository;
using HeladeriaAPI.Models;

namespace Heladeria2._1.Repositorios
{
    public class HeladoRepository : Repository<Helado>, IHelados
    {
        private readonly HeladeriaContext _db;
        public HeladoRepository(HeladeriaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Helado> Update(Helado entity)
        {
            _db.Heladoss.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        
    }
}
