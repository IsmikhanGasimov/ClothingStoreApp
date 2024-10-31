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
    public class SubCategoryConfig : EfBaseConfigurations<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.Property(x => x.SubCategoryName)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.HasOne(x => x.Category)
                   .WithMany(c => c.SubCategories)
                   .HasForeignKey(x => x.CategoryID);
            base.Configure(builder);
        }
    }
}
