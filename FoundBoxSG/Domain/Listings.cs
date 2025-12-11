namespace FoundBoxSG.Domain
{
    public class Listings : BaseDomainModel
    {
        public int UserId { get; set; }
        public string? ListingType { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ItemCategory { get; set; }
        public string? Brand { get; set; }
        public string? Location { get; set; }
        public string? UniqueFeatures { get; set; }
        public string? Color { get; set; }
        public string? Image { get; set; }
    }
}
