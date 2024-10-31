using ClothingStore.Domain.Accounts;
using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Entities
{
    public class Image:BaseEntity
    {
        public string Url { get; set; }
        public string ContentType { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int UserDetailId { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
