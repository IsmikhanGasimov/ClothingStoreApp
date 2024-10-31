using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Address:BaseEntity
    {
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Customer> Customers { get; set; }


    }
}
