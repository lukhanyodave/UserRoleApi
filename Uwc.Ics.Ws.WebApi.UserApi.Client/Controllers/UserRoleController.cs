using Azure;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserDto;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserRoleDTO;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;

namespace Uwc.Ics.Ws.WebApi.UserApi.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private object cancellationToken;

        public UserRoleController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetUserRoles()
        {
            var request = new GetAllRolesQuery();
            var userRoles = await _mediator.Send(request);
            return Ok(userRoles);        
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserRoleById(Guid id, CancellationToken cancellationToken)
        {
            var request = new GetUserRoleByIdQuery(id);
            CancellationTokenSource source = new CancellationTokenSource();
            CancellationToken token = source.Token;
             await _mediator.Send(new GetUserRoleByIdQuery(id));
           // return source;
            Task task = _mediator.Send(request, token);
            //var role = await task;
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CreateUsers(CreateUserRoleDto createUserRoleDto)
        {
           
            var request = new CreateUserRoleCommand(createUserRoleDto);
            // var roles = await _mediator.Send(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUserRole(UpdateUserRoleDto updateUserRoleDto)
        {
            //if (id != user.Id)
            //    return BadRequest();
            var request = new UpdateUserRoleCommand(updateUserRoleDto);
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
