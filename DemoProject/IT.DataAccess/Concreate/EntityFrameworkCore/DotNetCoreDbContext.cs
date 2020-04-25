using IT.DataAccess.Concreate.EntityFrameworkCore.Mapping;
using IT.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Concreate.EntityFrameworkCore
{
    public class DotNetCoreDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q3FAR2U\SQLEXPRESS;Database=DotNetCoreDB;integrated security=true;Connection Timeout=1800;MultipleActiveResultSets=True;");
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductImages> ProductImages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryMap());
            modelBuilder.ApplyConfiguration<Product>(new ProductMap());
            modelBuilder.ApplyConfiguration<ProductImages>(new ProductImageMap());
        }
    }
}
