using Microsoft.AspNetCore.Mvc;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
using AutoMapper;
using DebraEventAPI.Data;

namespace DebraEventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddEventController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAddEventRepo _addeventRepo;

        public AddEventController(IAddEventRepo addEventRepo, IMapper mapper)
        {
            _addeventRepo = addEventRepo;
            _mapper = mapper;
        }




        [HttpPost]
        public ActionResult CreateAddEvent(AddEventCreateDTO createDTO, int partnerId)
        {
            var model = _mapper.Map<AddEvent>(createDTO);
            model.PartnerId = partnerId;
            if (_addeventRepo.CreateAddEvent(model))
                return Ok();
            else
                return BadRequest();
        }


        [HttpGet("partner/{partnerId}")]
        public ActionResult <IEnumerable<AddEventReadDTO>> GetEventsByPartnerId (int partnerId)
        {
            var addEvents = _addeventRepo.GetEventsByPartnerId(partnerId);
            return Ok(_mapper.Map<IEnumerable<AddEventReadDTO>>(addEvents));
        }








        [HttpGet]
        public ActionResult <IEnumerable<AddEventReadDTO>> GetAddEvent()
        {
            var addevents = _addeventRepo.GetAllAddEvents();
            return Ok(_mapper.Map<IEnumerable<AddEventReadDTO>>(addevents));
        }




        [HttpPut("{id}")]
        public ActionResult UpdateAddEvent(int id, AddEventCreateDTO addeventupdate)
        {
            var addevent = _mapper.Map<AddEvent>(addeventupdate);
            addevent.Id = id;
            try
            {
                if (_addeventRepo.UpdateAddEvent(addevent))
                    return Ok();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occurred while updating the event");
            }
            
            return NotFound();
        }




        [HttpDelete("{id}")]
        public ActionResult DeleteAddEvent(int id)
        {
            var AddEvent = _addeventRepo.GetAddEvent(id);
            if (_addeventRepo.DeleteAddEvent(AddEvent))
                return Ok();
            else
                return NotFound();
        }




        [HttpGet("{id}", Name = "GetsByID")]

        public ActionResult <AddEventReadDTO> GetAddEvent(int id)
        {
            var addevent = _addeventRepo.GetAddEvent(id);
            if (addevent != null)
                    return Ok(_mapper.Map<AddEventReadDTO>(addevent));
            else
                return NotFound();
        }
    } 
}
