
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using IT.Entity.Concrete;
using System.Linq;



namespace IT.DataAccess.Concreate.EntityFrameworkCore.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
       

       public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable(@"Category", @"dbo");
            builder.HasKey(c => c.Id);


            builder.Property(c => c.AddedBy).HasColumnName("AddedBy       ");
            builder.Property(c => c.AddedDate).HasColumnName("AddedDate");
            builder.Property(c => c.isActive).HasColumnName("isActive");
            builder.Property(c => c.Name).HasColumnName("Name");
        }
    }
}
