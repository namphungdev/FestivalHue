using AutoMapper;
using FestivalHue.Dto;
using FestivalHue.Models;

namespace FestivalHue.Helpers
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {
            CreateMap<Admin, AdminDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
        }
    }
}
