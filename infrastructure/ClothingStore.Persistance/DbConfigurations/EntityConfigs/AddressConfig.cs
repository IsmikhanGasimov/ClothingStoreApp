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
    public class AddressConfig : EfBaseConfigurations<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.Street)
                   .IsRequired()
                   .HasMaxLength(255);
            builder.Property(x => x.PostalCode)
                   .IsRequired();
            builder.Property(x => x.CityName)
                   .IsRequired()
                   .HasMaxLength(100);
            builder.HasOne(x => x.Country)
                   .WithMany(c => c.Addresses)
                   .HasForeignKey(x => x.CountryId);
            base.Configure(builder);
        }
    }
}
