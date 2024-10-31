using ClothingStore.Domain.Entities;
using ClothingStore.Persistance.DbConfigurations.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.DbConfigurations.EntityConfigs
{
    public class ProductConfig : EfBaseConfigurations<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(x => x.Price)
                   .IsRequired()
                   .HasColumnType("decimal(18,2)");
            builder.Property(x => x.Description)
                   .HasMaxLength(1000);
            builder.HasOne(x => x.Types)
                   .WithMany(t => t.Products)
                   .HasForeignKey(x => x.TypesId);
            builder.HasOne(x => x.Vendor)
                   .WithMany(v => v.Products)
                   .HasForeignKey(x => x.VendorId);
            builder.HasOne(x => x.SubCategory)
                   .WithMany(sc => sc.Products)
                   .HasForeignKey(x => x.SubCategoryId);
            base.Configure(builder);
        }
    }
}
