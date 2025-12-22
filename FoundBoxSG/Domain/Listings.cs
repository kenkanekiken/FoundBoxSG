using System.ComponentModel.DataAnnotations.Schema;

namespace FoundBoxSG.Domain
{
    public class Listings : BaseDomainModel
    {
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual AppUser? User { get; set; }
        public string? ListingType { get; set; } 
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ItemCategory { get; set; }
        public string? Brand { get; set; }
        public string? Location { get; set; }
        public string? UniqueFeatures { get; set; }
        public string? Color { get; set; }
        public bool IsClose { get; set; } = false;
        public List<string> Images { get; set; } = new List<string>();
    }
}
