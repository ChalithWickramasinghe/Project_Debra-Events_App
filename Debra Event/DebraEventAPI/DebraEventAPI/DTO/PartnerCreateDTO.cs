using System.ComponentModel.DataAnnotations;

namespace DebraEventAPI.DTO
{
    public class PartnerCreateDTO
    {
        [Required]

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
