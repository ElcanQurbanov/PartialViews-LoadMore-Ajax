namespace FrontToBack.Models.Pricing
{
    public class Package:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public ICollection<Offer> Offers { get; set; }
    }
}
