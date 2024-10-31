using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Country:BaseEntity
    {
        public string CountryName { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}
