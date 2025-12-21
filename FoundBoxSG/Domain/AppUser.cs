using FoundBoxSG.Data;
using Microsoft.AspNetCore.Identity;

namespace FoundBoxSG.Domain
{
    public class AppUser : BaseDomainModel
    {
        public string? AspNetUserId { get; set; }

        public virtual FoundBoxSGUser? AspNetUser { get; set; }
        

        public virtual ICollection<Listings> Listings { get; set; } = new List<Listings>();
        public string? ProfileImageUrl { get; set; }
        public int TotalListings => Listings?.Count ?? 0;
        public string? Nationality { get; set; }
        public string? Region { get; set; }

        public bool IsBanned { get; set; } = false;
    }
}
