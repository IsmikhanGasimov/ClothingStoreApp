using ClothingStore.Application.Mappers;
using ClothingStore.Domain.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Dtos
{
    public class AuthenticatedUserDto : IMapTo<User>
    {
        public string Token { get; set; }
    }
}
