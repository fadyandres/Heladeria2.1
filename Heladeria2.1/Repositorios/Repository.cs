using Heladeria2._1.DatosPerrones;
using Heladeria2._1.Repositorios.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Heladeria2._1.Repositorios
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly HeladeriaContext _db;
        internal DbSet<T> dbSet;

        public Repository(HeladeriaContext db)
        {
            _db = db;
            dbSet = db.Set<T>();
        }

        
        public async Task Add(T entity)
        {
            await dbSet.AddAsync(entity);
            await Save();
        }

        public async Task<T> Get(Expression<Func<T, bool>>? filter, bool tracked)
        {
            IQueryable<T> query = dbSet;
            if (!tracked)
            {
                query = query.AsNoTracking();
            }
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> Getall(Expression<Func<T, bool>>? filter)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task Remove(T entity)
        {
            dbSet.Remove(entity);
            await Save();
        }

        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
