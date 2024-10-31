using ClothingStore.Domain.Accounts;
using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Review:BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int ReviewPoint { get; set; }
        public string Comment { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

    }
}
