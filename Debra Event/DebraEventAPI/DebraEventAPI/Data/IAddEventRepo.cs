using DebraEventAPI.Models;
namespace DebraEventAPI.Data
{
    public interface IAddEventRepo
    {
        bool Save();
        AddEvent GetAddEvent(int id);
        bool CreateAddEvent(AddEvent addEvent);
        bool UpdateAddEvent(AddEvent addEvent);
        bool DeleteAddEvent(AddEvent addEvent);

        IEnumerable<AddEvent> GetAllAddEvents();
        IEnumerable<AddEvent> GetEventsByPartnerId(int partnerId);




    }
}
