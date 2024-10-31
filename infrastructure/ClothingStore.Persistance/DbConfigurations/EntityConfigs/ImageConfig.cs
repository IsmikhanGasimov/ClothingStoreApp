using ClothingStore.Persistance.DbConfigurations.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Domain.Entities;

namespace ClothingStore.Persistance.DbConfigurations.EntityConfigs
{
    public class ImageConfig : EfBaseConfigurations<Image>
    {
        public override void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.Property(x => x.Url)
                   .IsRequired()
                   .HasMaxLength(1000);
            builder.Property(x => x.ContentType)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.HasOne(x => x.Product)
                   .WithMany(p => p.Images)
                   .HasForeignKey(x => x.ProductId);
            builder.HasOne(x => x.UserDetail)
                   .WithMany(ud => ud.Images)
                   .HasForeignKey(x => x.UserDetailId);
            base.Configure(builder);
        }
    }
}
