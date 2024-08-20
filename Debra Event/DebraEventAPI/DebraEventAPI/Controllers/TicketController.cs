using Microsoft.AspNetCore.Mvc;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
using DebraEventAPI.Data;
using AutoMapper;

namespace DebraEventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly ITicketRepo _ticketRepo;

        public TicketController(ITicketRepo ticketRepo, IMapper mapper)
        {
            _ticketRepo = ticketRepo;
            _mapper = mapper;
        }




        [HttpPost]
        public ActionResult CreateTicket(TicketCreateDTO CreateDTO)
        {
            var model = _mapper.Map<Ticket>(CreateDTO);
            model.Commission = model.Price * 0.10m;
            if (_ticketRepo.CreateTicket(model))
                return Ok();
            else
                return BadRequest();
        }




        [HttpGet("event/{eventId}")]
        public ActionResult<IEnumerable<TicketReadDTO>> GetTicketsByEventId(int eventId)
        {
            var ticket = _ticketRepo.GetTicketsByEventId(eventId);
            return Ok(_mapper.Map<IEnumerable<TicketReadDTO>>(ticket));
        }


        [HttpPost("{id}/sell")]
        public ActionResult SellTicket(int id)
        {
            var ticket = _ticketRepo.GetTicket(id);
            if (ticket != null && !ticket.IsSold)
            {
                ticket.IsSold = true;
                ticket.SaleDate = DateTime.Now;
                if (_ticketRepo.UpdateTicket(ticket))
                    return Ok("Ticket sold successfully.");
                else
                    return BadRequest("Error updating ticket status.");
            }
            else
            {
                return NotFound("Ticket not found or already sold.");
            }
        }







        [HttpGet]
        public ActionResult<IEnumerable<TicketReadDTO>> GetTicket()
        {
            var ticket = _ticketRepo.GetAllTickets();
            return Ok(_mapper.Map<IEnumerable<TicketReadDTO>>(ticket));
        }




        [HttpPut("{id}")]
        public ActionResult UpdateTicket(int id, TicketCreateDTO ticketUpdate)

        {
            var ticket = _mapper.Map<Ticket>(ticketUpdate);
            ticket.Id = id;
            if (_ticketRepo.UpdateTicket(ticket))
                return Ok();
            else
                return NotFound();
        }




        [HttpDelete("{id}")]
        public ActionResult DeleteTicket(int id)
        {
            var ticket = _ticketRepo.GetTicket(id);
            if (_ticketRepo.DeleteTicket(ticket))
                return Ok();
            else return
                    NotFound();
        }




        [HttpGet("{id}", Name = "GetByID")]
        public ActionResult<TicketReadDTO> GetTicket(int id)
        {
            var ticket = _ticketRepo.GetTicket(id);
            if (ticket != null)
                return Ok(_mapper.Map<TicketReadDTO>(ticket));
            else
                return NotFound();
        }



    }

    }

