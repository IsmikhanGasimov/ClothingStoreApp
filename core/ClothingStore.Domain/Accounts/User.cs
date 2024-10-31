using ClothingStore.Domain.Common;
using ClothingStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Domain.Accounts
{
    public class User
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public UserDetail UserDetail { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<Review> Reviews { get; set; }

    }
}
