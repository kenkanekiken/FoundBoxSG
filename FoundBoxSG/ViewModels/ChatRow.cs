namespace FoundBoxSG.ViewModels
{
    public class ChatRow
    {
        public int MatchId { get; set; }
        public int ListingId { get; set; }
        public string? ListingTitle { get; set; }
        public int OtherUserId { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}
