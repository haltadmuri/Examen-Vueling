using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class DbContextFruit: DbContext, IUnitOfWork, IDbContext
    {
        public DbSet<Product> Products { get; set; } // Needed for database seed purposes.
        public DbSet<Ticket> Tickets { get; set; }

        public DbContextFruit()
            : base("DefaultConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
        }

        public DbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

        IDbSet<TEntity> IDbContext.GetSet<TEntity>()
        {
            return this.Set<TEntity>();
        }
    }
}
