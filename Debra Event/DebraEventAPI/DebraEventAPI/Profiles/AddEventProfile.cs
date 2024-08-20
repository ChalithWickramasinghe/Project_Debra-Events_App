using AutoMapper;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
namespace DebraEventAPI.Profiles
{
    public class AddEventProfile:Profile
    {
        public AddEventProfile()
        {
            CreateMap<AddEvent, AddEventReadDTO>();
            CreateMap<AddEventCreateDTO, AddEvent>();
        }
    }
}
