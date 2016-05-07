﻿using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class UsersContext : DbContext, IDbContext, IUnitOfWork
    {
        public UsersContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<UserProfile> UserProfiles { get; set; }
        public DbSet<Product> Products { get; set; }

        //public DbSet<Ticket> Tickets { get; set; }
        //public DbSet<Invoice> Invoices { get; set; }


        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : class
        {
            return Set<TEntity>();

        }
    }

}
