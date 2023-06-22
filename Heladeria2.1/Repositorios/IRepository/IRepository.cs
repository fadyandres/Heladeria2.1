using System.Linq.Expressions;

namespace Heladeria2._1.Repositorios.IRepository
{
    public interface IRepository <T> where T : class
    {
        Task Add(T entity);
        Task<List<T>> Getall(Expression<Func<T, bool>>? filter = null);
        Task<T> Get(Expression<Func<T, bool>>? filter = null, bool tracked = true);
        Task Remove(T entity);
        Task Save();

        


    }
}
