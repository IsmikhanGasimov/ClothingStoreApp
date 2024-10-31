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
    public class OrderConfig : EfBaseConfigurations<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.CommitOrder).IsRequired();
            builder.HasOne(x => x.Product)
                   .WithMany(p => p.Orders)
                   .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.Customer)
                   .WithMany(c => c.Orders)
                   .HasForeignKey(x => x.CustomerId);
            base.Configure(builder);
        }
    }
}
