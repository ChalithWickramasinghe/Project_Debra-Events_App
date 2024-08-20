using AutoMapper;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
namespace DebraEventAPI.Profiles
{
    public class TicketProfile:Profile
    {
        public TicketProfile()
        {
            CreateMap<Ticket, TicketReadDTO>();
            CreateMap<TicketCreateDTO, Ticket>();
        }
    }
}
