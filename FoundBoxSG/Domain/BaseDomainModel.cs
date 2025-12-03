namespace FoundBoxSG.Domain
{
    public abstract class BaseDomainModel
    {
        public int Id { get; set; }
        public string? CreatedBy { get; set; }  
        public string? ModifiedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateModified { get; set; }
    }
}
