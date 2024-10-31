using ClothingStore.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Features.Command
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, AuthenticatedUserDto>
    {
        public Task<AuthenticatedUserDto> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
