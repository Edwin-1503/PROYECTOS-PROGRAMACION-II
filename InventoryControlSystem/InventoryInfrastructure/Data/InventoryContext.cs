using System.Collections.Generic;
using InventoryDomain.Core.Entities;
using InventoryInfrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;



namespace InventoryInfrastructure.Data
{
    public class InventoryContext : DbContext
    {
        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
