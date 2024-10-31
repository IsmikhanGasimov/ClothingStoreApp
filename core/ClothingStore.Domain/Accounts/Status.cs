using ClothingStore.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Accounts
{
    public class Status
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public ICollection<User> User { get; set; }

    }
}
