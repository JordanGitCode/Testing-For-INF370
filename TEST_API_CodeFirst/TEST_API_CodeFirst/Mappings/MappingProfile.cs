using AutoMapper;
using TEST_API_CodeFirst.Models;

namespace TEST_API.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<User, UserDTO>();

            CreateMap<UserDTO, User>();
        }
    }
}
