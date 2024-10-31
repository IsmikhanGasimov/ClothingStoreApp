using ClothingStore.Application.Interfaces;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.EntityFrameworks.Repositories
{
    public class EfCustomerRepository : EfGenericRepository<Customer>, ICustomerRepository
    {
        public EfCustomerRepository(ClothingStoreContext dbContext) : base(dbContext)
        {
        }
    }
}
