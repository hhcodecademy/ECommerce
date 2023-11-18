using ECommerce.DAL.DBModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x=>x.Price).HasPrecision(18,2).IsRequired();
            builder.Property(x => x.Rating).HasPrecision(18, 2);
            builder.Property(x => x.DiscountPercentage).HasPrecision(18, 2);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Brand).IsRequired();
            builder.Property(x => x.ProductCategoryId).IsRequired();

            builder.HasOne(x => x.ProductCategory)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.ProductCategoryId);

        }
    }
}
