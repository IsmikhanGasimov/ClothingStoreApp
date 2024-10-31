using ClothingStore.Application.Interfaces;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Persistance.EntityFrameworks.Repositories
{
    public class EfImageRepository : EfGenericRepository<Image>, IImageRepository
    {
        public EfImageRepository(ClothingStoreContext dbContext) : base(dbContext)
        {
        }
    }
}
