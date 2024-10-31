using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class SubCategory:BaseEntity
    {
        public string SubCategoryName { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
