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
    public class CustomerConfig : EfBaseConfigurations<Customer>
    {
        public override void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(x => x.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(x => x.LastName)
                   .IsRequired()
                   .HasMaxLength(50);
            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasMaxLength(255);
            builder.HasOne(x => x.Address)
                   .WithMany(a => a.Customers)
                   .HasForeignKey(x => x.AddressId);
            base.Configure(builder);
        }
    }
}
