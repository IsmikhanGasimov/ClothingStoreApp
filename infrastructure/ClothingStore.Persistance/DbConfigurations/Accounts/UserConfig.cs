using ClothingStore.Domain.Entities;
using ClothingStore.Persistance.DbConfigurations.Commons;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothingStore.Domain.Accounts;

namespace ClothingStore.Persistance.DbConfigurations.Accounts
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasIndex(x => x.Mail)
                   .IsUnique();
            builder.Property(x => x.Mail)
                   .IsRequired();

            builder.HasMany(x => x.UserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasOne(x => x.UserDetail).WithOne(x => x.User).HasForeignKey<UserDetail>(x => x.UserId);
        }
    }
}
