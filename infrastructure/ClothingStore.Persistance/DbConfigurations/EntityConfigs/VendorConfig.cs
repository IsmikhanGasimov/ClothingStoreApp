using ClothingStore.Domain.Entities;
using ClothingStore.Persistance.DbConfigurations.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.DbConfigurations.EntityConfigs
{
    public class VendorConfig : EfBaseConfigurations<Vendor>
    {
        public override void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.Property(x => x.VendorName)
                   .IsRequired()
                   .HasMaxLength(50);
            base.Configure(builder);
        }
    }
}
