using ClothingStore.Application.Dtos;
using ClothingStore.Application.Features.Command;
using ClothingStore.Application.Features.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ApiControllerBase
    {
        public ProductsController(IMediator mediator):base(mediator)
        {
            
        }

        [HttpGet]
        [ActionName("products")]
        public async Task<ActionResult<ApiResponseModel<IEnumerable<ProductViewDto>>>> GetProductsAsync()
        {
            var products = await _mediator.Send(new GetAllProductQuery());
            return await SuccessResult("Products data is selecte", products);
        }




        [HttpPost]
        [ActionName("products")]
        public async Task<ActionResult<ApiResponseModel<string>>> AddProducts(AddProductCommand command)
        {
            await _mediator.Send(command);
            return await SuccessResult<string>("Product added succesfully");
        }





    }
}
