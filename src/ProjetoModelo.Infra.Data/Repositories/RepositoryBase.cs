using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Infra.Data.Contextos;
using System.Linq.Expressions;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext context;

        private RepositoryBase(RepositoryContext context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            this.context.Set<T>().Add(entity);
        }

        public async Task<T> GetByCondition(Expression<Func<T, bool>> expression)
        {
            return await this.context.Set<T>().Where(expression).AsNoTracking().FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this.context.Set<T>().AsNoTracking().ToListAsync();
        }

        public void Update(T entity)
        {
            this.context.Set<T>().Update(entity);
        }

        public void Remove(T entity)
        {
            this.context.Set<T>().Remove(entity);
        }       
    }
}
