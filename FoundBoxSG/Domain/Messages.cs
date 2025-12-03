namespace FoundBoxSG.Domain
{
    public class Messages : BaseDomainModel
    {
        public int SenderUserId { get; set; }
        public int ReceiverUserId { get; set; }
        public int MatchId { get; set; }
        public string? Content { get; set; }
    }
}
