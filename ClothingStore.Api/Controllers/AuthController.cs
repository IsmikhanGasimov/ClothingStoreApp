using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClothingStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ApiControllerBase
    {
        public AuthController(IMediator mediator) : base(mediator)
        {
        }

        /*[HttpPost]
        [ActionName("SignUp")]
        public async Task<ActionResult<ApiResponseModel<AuthenticatedUserDto>>> Register(CreatUserCommand command)
        {
            var result = await _mediator.Send(command);

            return await SuccessResult("Token generated successfully", result);
        }

        [HttpPost]
        [ActionName("SignIn")]
        public async Task<ActionResult<ApiResponseModel<AuthenticatedUserDto>>> Login(GenerateTokenCommand command)
        {
            var result = await _mediator.Send(command);

            return await SuccessResult("Token generated successfully", result);
        }*/
    }
}
