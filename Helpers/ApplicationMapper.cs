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
            CreateMap<Group, GroupDto>().ReverseMap();
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Programm, ProgrammDto>().ReverseMap();
            CreateMap<About, AboutDto>().ReverseMap();
            CreateMap<Menu, MenuDto>().ReverseMap();
            CreateMap<SubMenu, SubMenuDto>().ReverseMap();
            CreateMap<Service, ServiceDto>().ReverseMap();
            CreateMap<TicketLocation, TicketLocationDto>().ReverseMap();
        }
    }
}
