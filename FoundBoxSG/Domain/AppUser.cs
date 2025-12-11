using FoundBoxSG.Data;
using Microsoft.AspNetCore.Identity;

namespace FoundBoxSG.Domain
{
    public class AppUser : BaseDomainModel
    {
        public string? AspNetUserId { get; set; }

        public virtual FoundBoxSGUser? AspNetUser { get; set; }
        public int TotalListings { get; set; }
        public string? ProfileImageUrl { get; set; }
        public string? Nationality { get; set; }
        public string? Region { get; set; }
    }
}
