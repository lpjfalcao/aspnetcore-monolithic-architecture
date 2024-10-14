using Microsoft.EntityFrameworkCore;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Configurations;

namespace ProjetoModeloDDD.Infra.Data.Contextos
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
