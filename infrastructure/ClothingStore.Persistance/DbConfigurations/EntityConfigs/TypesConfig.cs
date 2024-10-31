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
    public class TypesConfig : EfBaseConfigurations<Types>
    {
        public override void Configure(EntityTypeBuilder<Types> builder)
        {
            builder.Property(x => x.TypesName)
               .IsRequired()
               .HasMaxLength(100);
            base.Configure(builder);
        }
    }
}
