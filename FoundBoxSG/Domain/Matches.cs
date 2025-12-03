namespace FoundBoxSG.Domain
{
    public class Matches : BaseDomainModel
    {
        public int FoundListingId { get; set; }
        public int LostListingId { get; set; }
    }
}
