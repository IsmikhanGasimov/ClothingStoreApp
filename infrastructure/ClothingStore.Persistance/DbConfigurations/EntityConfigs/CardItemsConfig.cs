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
    public class CardItemsConfig : EfBaseConfigurations<CardItems>
    {
        public override void Configure(EntityTypeBuilder<CardItems> builder)
        {
            builder.Property(x => x.Quantity).IsRequired();
            builder.HasOne(x => x.Product)
                   .WithMany(p => p.CardItems)
                   .HasForeignKey(x => x.ProductId);
            base.Configure(builder);
        }
    }
}
