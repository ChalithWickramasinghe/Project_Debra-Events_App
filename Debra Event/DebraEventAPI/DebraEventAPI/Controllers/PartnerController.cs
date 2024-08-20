using Microsoft.AspNetCore.Mvc;
using DebraEventAPI.Models;
using DebraEventAPI.DTO;
using DebraEventAPI.Data;
using AutoMapper;

namespace DebraEventAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartnerController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPartnerRepo _partnerRepo;

        public PartnerController(IPartnerRepo partnerRepo, IMapper mapper)
        {
            _partnerRepo = partnerRepo;
            _mapper = mapper;
        }


        [HttpPost("login")]
        public ActionResult<PartnerReadDTO> Login(LoginDTO loginDTO)
        {
            var partner = _partnerRepo.Login(loginDTO.Email, loginDTO.Password);
            if (partner == null)
            {
                return Unauthorized();
            }
            return Ok(_mapper.Map<PartnerReadDTO>(partner));
        }




        [HttpPost]
        public ActionResult CreatePartner(PartnerCreateDTO CreateDTO)
        {
            var model = _mapper.Map<Partner>(CreateDTO);
            if (_partnerRepo.CreatePartner(model))
                return Ok();
            else
                return BadRequest();
        }



        [HttpGet]
        public ActionResult<IEnumerable<PartnerReadDTO>> GetPartner()
        {
            var partner = _partnerRepo.GetAllPartners();
            return Ok(_mapper.Map<IEnumerable<PartnerReadDTO>>(partner));
        }



        [HttpPut("{id}")]
        public ActionResult UpdatePartner(int id, PartnerCreateDTO partnerUpdate)

        {
            var partner = _mapper.Map<Partner>(partnerUpdate);
            partner.Id = id;
            if (_partnerRepo.UpdatePartner(partner))
                return Ok();
            else
                return NotFound();
        }




        [HttpDelete("{id}")]
        public ActionResult DeletePartner(int id)
        {
            var partner = _partnerRepo.GetPartner(id);
            if (_partnerRepo.DeletePartner(partner))
                return Ok();
            else 
                return NotFound();
        }



        [HttpGet("{id}", Name ="GetBysID")]
        public ActionResult<PartnerCreateDTO> GetPartner(int id)
        {
            var partner= _partnerRepo.GetPartner(id);
            if (partner != null)
                return Ok(_mapper.Map<PartnerReadDTO>(partner));
            else
                return NotFound();
        }
    }
}
