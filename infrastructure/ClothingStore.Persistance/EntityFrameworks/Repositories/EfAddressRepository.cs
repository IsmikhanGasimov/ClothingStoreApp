using ClothingStore.Application.Interfaces;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.EntityFrameworks.Repositories
{
    public class EfAddressRepository : EfGenericRepository<Address>, IAddressRepository
    {
        public EfAddressRepository(ClothingStoreContext dbContext) : base(dbContext)
        {
        }
    }
}
