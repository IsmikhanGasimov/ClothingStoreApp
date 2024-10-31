using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Vendor:BaseEntity
    {
        public string VendorName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
