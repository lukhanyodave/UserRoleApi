using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.RoleDTO;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserRoleFeature.Request.Commands;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;

namespace Uwc.Ics.Ws.WebApi.UserApi.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RoleController(IMediator mediator) => _mediator = mediator;

        [HttpGet]
        public async Task<ActionResult> GetRoles()
        {
            var request = new GetAllRolesQuery();
            var roles = await _mediator.Send(request);
            return Ok(roles);        
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRole(Guid id, CancellationToken token)
        {
            var request = new GetUserRoleByIdQuery(id);
            await _mediator.Send(request,token);            
            return Ok();
        }
        [HttpPost]
        public async Task<ActionResult> CreateRoles(CreateRoleDto role)
        {
            var request = new CreateRoleCommand(role);
            await _mediator.Send(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItem(UpdateRoleDto updateRoleDto)
        {
            //if (id != user.Id)
            //    return BadRequest();
            var request = new UpdateRoleCommand(updateRoleDto);
            await _mediator.Send(request);
            //await _unitOfWork.Users.Upsert(user);
            //await _unitOfWork.CompleteAsync();

            // Following up the REST standart on update we need to return NoContent
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItem(Guid id)
        {
            var request = new DeleteRoleCommand(id);
            await _mediator.Send(request);
            //var item = await _unitOfWork.Users.GetById(id);

            //if (item == null)
            //    return BadRequest();

            //await _unitOfWork.Users.Delete(id);
            //await _unitOfWork.CompleteAsync();

            return NoContent();
        }
    }
}
