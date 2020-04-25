using IT.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace IT.DataAccess.Concreate.EntityFrameworkCore.Mapping
{
    public class ProductImageMap : IEntityTypeConfiguration<ProductImages>
    {
        public void Configure(EntityTypeBuilder<ProductImages> builder)
        {
            builder.ToTable(@"ProductImages", "dbo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ProductId).HasColumnName("ProductId");
            builder.Property(x => x.FileName).HasColumnName("FileName");
            builder.Property(x => x.FilePath).HasColumnName("FilePath");
            builder.Property(x => x.AddedBy).HasColumnName("AddedBy");
            builder.Property(x => x.AddedDate).HasColumnName("AddedDate");
            
        }
    }
}
