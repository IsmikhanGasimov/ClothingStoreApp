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
    public class ReviewConfig : EfBaseConfigurations<Review>
    {
        public override void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.Property(x => x.ReviewPoint).IsRequired();
            builder.Property(x => x.Comment).HasMaxLength(1000);
            builder.HasOne(x => x.User)
                   .WithMany(u => u.Reviews)
                   .HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.Product)
                   .WithMany(p => p.Reviews)
                   .HasForeignKey(x => x.ProductId);
            base.Configure(builder);
        }
    }
}
