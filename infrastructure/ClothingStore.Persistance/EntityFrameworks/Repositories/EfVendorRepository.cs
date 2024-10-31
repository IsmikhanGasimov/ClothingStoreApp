using ClothingStore.Application.Interfaces;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.EntityFrameworks.Repositories
{
    public class EfVendorRepository : EfGenericRepository<Vendor>, IVendorRepository
    {
        public EfVendorRepository(ClothingStoreContext dbContext) : base(dbContext)
        {
        }
    }
}
