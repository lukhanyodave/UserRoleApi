using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using MediatR;
//using Uwc.Ics.Ws.WebApi.UserApi.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Handlers.QueryHandlers;
public class GetRoleByIdHandler : IRequestHandler<GetUserByIdQuery>
{
    private readonly IUserRepository userRepository;
    public GetRoleByIdHandler(IUserRepository userRepository) => this.userRepository = userRepository;
    public async Task Handle(GetUserByIdQuery request, CancellationToken cancellationToken) => await userRepository.GetUserById(request.Id);
};