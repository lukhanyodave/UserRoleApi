using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.RoleDTO;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserDto;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;

namespace Uwc.Ics.Ws.WebApi.UserApi.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            var query = new GetAllUsersQuery();
            //var products = await _mediator.Send(query);
           // return Ok(products);
            var users = await _mediator.Send(query, default(CancellationToken));
            return Ok(users);        
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var request = new GetUserByIdQuery(id);
            await _mediator.Send(request, default(CancellationToken));
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CreateUsers(CreateUserDto createUserDto)
        {
            var request = new CreateUserCommand(createUserDto);
           await _mediator.Send(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpadateUser(UpdateUserDto updateUserDto)
        {
            //if (id != user.Id)
            //    return BadRequest();
            var request = new UpdateUserCommand(updateUserDto);
            // var roles = await _mediator.Send(request);
            //await _unitOfWork.Users.Upsert(user);
            //await _unitOfWork.CompleteAsync();

            // Following up the REST standart on update we need to return NoContent
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            //var request = new DeleteUserCommand(id);
            //var role = await _mediator.Send(request);
            //var item = await _unitOfWork.Users.GetById(id);

            //if (item == null)
            //    return BadRequest();

            //await _unitOfWork.Users.Delete(id);
            //await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
