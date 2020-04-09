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
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-Q3FAR2U\SQLEXPRESS;Database=DotNetCoreDB;integrated security=true;Connection Timeout=1800;MultipleActiveResultSet=True");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
