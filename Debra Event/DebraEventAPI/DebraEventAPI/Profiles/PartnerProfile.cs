using AutoMapper;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
namespace DebraEventAPI.Profiles
{
    public class PartnerProfile:Profile
    {
        public PartnerProfile()
        {
            CreateMap<Partner, PartnerReadDTO>();
            CreateMap<PartnerCreateDTO, Partner>();
        }
    }
}
