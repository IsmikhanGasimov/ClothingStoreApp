using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<SubCategory> SubCategories { get; set; }
    }
}
