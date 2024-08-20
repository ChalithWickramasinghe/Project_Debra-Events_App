using DebraEventAPI.Models;
namespace DebraEventAPI.Data
{
    public interface ITicketRepo
    {
        bool Save();
        Ticket GetTicket(int id);
        bool CreateTicket(Ticket ticket);
        bool UpdateTicket(Ticket ticket);
        bool DeleteTicket(Ticket ticket);

        IEnumerable<Ticket> GetAllTickets();
        IEnumerable<Ticket> GetTicketsByEventId(int eventId);
    }
}
