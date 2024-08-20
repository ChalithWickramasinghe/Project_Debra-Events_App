namespace DebraEventAPI.DTO
{
    public class PartnerReadDTO
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
