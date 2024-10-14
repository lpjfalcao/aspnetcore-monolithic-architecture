using ProjetoModeloDDD.Infra.Data.Contextos;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class UnityOfWork
    {
        private bool disposed = false;
        private RepositoryContext context;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
