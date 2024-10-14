using System.Linq.Expressions;

namespace ProjetoModeloDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T entity);
        Task<T> GetByCondition(Expression<Func<T, bool>> expression);
        Task<IEnumerable<T>> GetAll();
        void Update(T entity);
        void Remove(T entity);
    }
}
