using ClothingStore.Application.Dtos;
using ClothingStore.Application.Mappers;
using ClothingStore.Domain.Accounts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Features.Command
{
    public class CreateUserCommand:IMapTo<User>, IMapTo<UserDetail>, IRequest<AuthenticatedUserDto>
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
    }
}

