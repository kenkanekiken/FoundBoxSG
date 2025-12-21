namespace FoundBoxSG.Domain
{
    public class Messages : BaseDomainModel
    {
        public int MatchId { get; set; }
        public int SenderUserId { get; set; }
        public string? Content { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
