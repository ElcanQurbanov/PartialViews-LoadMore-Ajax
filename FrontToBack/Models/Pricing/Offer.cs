namespace FrontToBack.Models.Pricing
{
    public class Offer:BaseEntity
    {
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? Feature { get; set; }
        public int PackaceId { get; set; }
        public Package Package { get; set; }
    }
}
