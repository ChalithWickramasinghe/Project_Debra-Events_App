namespace DebraEventAPI.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public decimal Commission {  get; set; }
        public DateTime? SaleDate { get; set; }
        public int EventId { get; set; }

    }
}
