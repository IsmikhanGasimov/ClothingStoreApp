using ClothingStore.Domain.Accounts;
using ClothingStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.EntityFrameworks
{
    public class ClothingStoreContext: DbContext
    {
        public ClothingStoreContext(DbContextOptions<ClothingStoreContext> optionsBuilder) : base(optionsBuilder)
        {

        }

        public DbSet<Address> Addresses => this.Set<Address>();
        public DbSet<CardItems> CardItems => this.Set<CardItems>();
        public DbSet<Category> Categories => this.Set<Category>();
        public DbSet<Country> Countries => this.Set<Country>();
        public DbSet<Customer> Customers => this.Set<Customer>();
        public DbSet<Image> Images => this.Set<Image>();
        public DbSet<Order> Orders => this.Set<Order>();
        public DbSet<Product> Products => this.Set<Product>();
        public DbSet<Review> Reviews => this.Set<Review>();
        public DbSet<Role> Roles => this.Set<Role>();
        public DbSet<Status> Statuses => this.Set<Status>();
        public DbSet<SubCategory> SubCategories => this.Set<SubCategory>();
        public DbSet<Types> Types => this.Set<Types>();
        public DbSet<User> Users => this.Set<User>();
        public DbSet<UserDetail> UserDetails => this.Set<UserDetail>();
        public DbSet<UserRole> UserRoles => this.Set<UserRole>();
        public DbSet<Vendor> Vendors => this.Set<Vendor>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
