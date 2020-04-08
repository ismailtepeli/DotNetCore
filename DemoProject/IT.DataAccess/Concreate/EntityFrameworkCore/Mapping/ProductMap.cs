using IT.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Concreate.EntityFrameworkCore.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product", "dbo");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.AddedBy).HasColumnName("AddedBy");
            builder.Property(p => p.AddedDate).HasColumnName("AddedDate");
            builder.Property(p => p.CategoryId).HasColumnName("CategoryId");
            builder.Property(p => p.Explanation).HasColumnName("Explanation");
            builder.Property(p => p.Height).HasColumnName("Height");
            builder.Property(p => p.Weight).HasColumnName("Weight");
            builder.Property(p => p.Width).HasColumnName("Width");
        }
    }
}
