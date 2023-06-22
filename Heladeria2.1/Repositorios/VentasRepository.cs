using Heladeria2._1.DatosPerrones;
using Heladeria2._1.Repositorios.IRepository;
using HeladeriaAPI.Models;

namespace Heladeria2._1.Repositorios
{
    public class VentasRepository : Repository<Ventas>, IVentas
    {
        private readonly HeladeriaContext _db;
        public VentasRepository(HeladeriaContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Ventas> Update(Ventas entity)
        {
            _db.Ventass.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

       
    }
}
