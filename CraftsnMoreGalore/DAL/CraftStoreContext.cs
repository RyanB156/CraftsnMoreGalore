using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using CraftsnMoreGalore.Models;

namespace CraftsnMoreGalore.DAL
{
    public class CraftStoreContext : DbContext
    {
        public CraftStoreContext() : base("CraftStoreContext")
        {

        }

        public DbSet<Craft> Crafts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}