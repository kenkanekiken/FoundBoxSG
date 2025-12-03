namespace FoundBoxSG.Domain
{
    public class AppUser : BaseDomainModel
    {
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public string? Gender { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Nationality { get; set; }
        public string? Region { get; set; }
    }
}
