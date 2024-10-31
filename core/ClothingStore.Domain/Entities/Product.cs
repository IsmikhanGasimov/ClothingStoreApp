using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int TypesId { get; set; }
        public Types Types { get; set; }
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public ICollection<CardItems> CardItems { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Order> Orders{ get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
