using ClothingStore.Domain.Accounts;
using ClothingStore.Domain.Entities;
using ClothingStore.Persistance.DbConfigurations.Commons;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.DbConfigurations.Accounts
{
    public class UserDetailConfig : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                   .HasMaxLength(50);
            builder.Property(x => x.LastName)
                   .HasMaxLength(50);
        }
    }
}
