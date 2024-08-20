using DebraEventAPI.Models;
namespace DebraEventAPI.Data
{
    public class TicketRepo : ITicketRepo
    {
        private readonly DBContext _dbContext;
        public TicketRepo(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateTicket(Ticket ticket)
        {
            if (ticket != null)
            {
                _dbContext.Tickets.Add(ticket);
                return Save();
            }
            else
                return false;
        }

        public bool DeleteTicket(Ticket ticket)
        {
            if (ticket != null)
            {
                _dbContext.Tickets.Remove(ticket);
                return Save();
            }
            else
                return false ;
        }

        public IEnumerable<Ticket> GetAllTickets()
        {
            return _dbContext.Tickets.ToList();
        }

        public Ticket GetTicket(int id)
        {
            return _dbContext.Tickets.FirstOrDefault(ticket => ticket.Id == id);
        }

        public bool Save()
        {
            int count = _dbContext.SaveChanges();
            if (count > 0)
                return true;
            else
                return false;
        }

        public bool UpdateTicket(Ticket ticket)
        {
            _dbContext.Tickets.Update(ticket);
            return Save();
        }

        public IEnumerable<Ticket> GetTicketsByEventId(int id)
        {
            return _dbContext.Tickets.Where(ticket => ticket.EventId == id).ToList();
        }
    }
}
