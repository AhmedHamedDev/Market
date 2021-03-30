using Market.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market
{
    public class MarketDbContext : DbContext
    {
        public MarketDbContext() : base("name=MarketConnectionString") 
        {
            Database.SetInitializer<MarketDbContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOptional(x => x.Client).WithMany(x => x.Orders).HasForeignKey(x => x.ClientId);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<GeneralProductType> GeneralProductTypes { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Models.OrderDetails> OrderDetails { get; set; }
    }

}
