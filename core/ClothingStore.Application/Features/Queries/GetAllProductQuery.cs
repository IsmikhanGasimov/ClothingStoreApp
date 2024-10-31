using ClothingStore.Application.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingStore.Application.Features.Queries
{
    public class GetAllProductQuery:IRequest<IEnumerable<ProductViewDto>>
    {
    }
}
