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
    public class CategoryConfig : EfBaseConfigurations<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x => x.CategoryName)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.HasMany(x => x.SubCategories)
                   .WithOne(sc => sc.Category)
                   .HasForeignKey(sc => sc.CategoryID);
            base.Configure(builder);
        }
    }
}
