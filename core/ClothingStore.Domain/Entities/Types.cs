using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Types:BaseEntity
    {
        public string TypesName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
