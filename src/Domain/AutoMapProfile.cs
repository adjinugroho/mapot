using AutoMapper;
using Core.EntityTables;
using Domain.Application;
using Domain.User;

namespace Domain
{
    public class AutoMapProfile : Profile
    {
        public AutoMapProfile()
        {
            CreateMap<TAppUser, UserDto>().ReverseMap();
            CreateMap<TAppApplication, ApplicationDto>().ReverseMap();
        }
    }
}
