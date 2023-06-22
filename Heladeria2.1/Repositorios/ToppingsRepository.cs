using Heladeria2._1.DatosPerrones;
using Heladeria2._1.Repositorios.IRepository;
using HeladeriaAPI.Models;

namespace Heladeria2._1.Repositorios
{
    public class ToppingsRepository : Repository <Toppings> , IToppings
    {
        private readonly HeladeriaContext _db;
        public ToppingsRepository(HeladeriaContext db) : base(db)
        {
            _db = db;
        }
        public async Task<Toppings> Update(Toppings entity)
        {
            _db.Toppingss.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
