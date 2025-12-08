namespace FoundBoxSG.Domain
{
    public class AppUser : BaseDomainModel
    {
        public int TotalListings { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Nationality { get; set; }
        public string? Region { get; set; }
    }
}
