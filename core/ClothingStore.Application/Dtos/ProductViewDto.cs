using ClothingStore.Application.Mappers;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Dtos
{
    public class ProductViewDto: IMapTo<Product>
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int TypesId { get; set; }
        public int VendorId { get; set; }
        public int SubCategoryId { get; set; }
    }
}
