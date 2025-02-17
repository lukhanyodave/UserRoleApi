using AutoMapper;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.RoleDTO;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserRoleDTO;
using Uwc.Ics.Ws.WebApi.UserApi.Application.DTOs.UserDto;
using Uwc.Ics.Ws.WebApi.UserApi.Domain.Entities;
using System;

namespace Uwc.Ics.Ws.WebApi.UserApi.Application.Profiles
{
    public class MappingProfile : Profile
    {
        #region Role Mappings 
        public MappingProfile()
        {
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Role, RoleListDto>()
                    .ForMember(dest => dest.CommencementDate, opt => opt.MapFrom(src => src.DateCreated))
                    .ReverseMap();
            CreateMap<Role, CreateRoleDto>().ReverseMap();
            CreateMap<Role, UpdateRoleDto>().ReverseMap();
            #endregion  Role Mappings 
            #region userRole Mapping
            CreateMap<UserRole, UserRoleDto>().ReverseMap();
            CreateMap<UserRole, UserRoleListDto>()
                    .ForMember(dest => dest.CommencementDate, opt => opt.MapFrom(src => src.DateCreated))
                    .ReverseMap();
            CreateMap<UserRole, CreateUserRoleDto>().ReverseMap();
            CreateMap<UserRole, UpdateUserRoleDto>().ReverseMap();
            #endregion  UserRole Mappings
            #region User Mapping
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<User, UserListDto>()
                    .ForMember(dest => dest.CommencementDate, opt => opt.MapFrom(src => src.DateCreated))
                    .ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
            #endregion  User Mappings
        }


    }
}
