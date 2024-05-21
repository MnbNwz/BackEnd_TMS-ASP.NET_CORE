using AutoMapper;
using tms.Server.Models;
using tms.Server.DTOs;

namespace tms.Server.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ApplicationUser, SignUpDTO>();
            CreateMap<SignUpDTO, ApplicationUser>();

        }
    }
}
