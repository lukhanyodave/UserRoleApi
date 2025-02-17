using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Abstraction;
using Uwc.Ics.Ws.WebApi.UserApi.Persistance;
using Uwc.Ics.Ws.WebApi.UserApi.Persistance.Repository;
using MediatR;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.UserFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Request.Queries;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;
using Uwc.Ics.Ws.WebApi.UserApi.Application.Features.RoleFeature.Handlers.QueryHandlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//register the services 
//builder.Services
//    .AddApplicationServices()
 //   .AddInfrastructure();
//builder.Services.AddApplicationServices();
//builder.Services.AddInfrastructureServices(builder.Configuration);
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
//builder.Services.AddScoped(typeof(IRequestHandler<GetUserByIdQuery, UserResponse>), typeof(GetUserByIdHandler));
builder.Services.AddScoped(typeof(IRequestHandler<GetAllRolesQuery, List<Role>>), typeof(GetAllRolesHandler));

//add UserContext
var cs = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseSqlServer(cs));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
