using Microsoft.AspNetCore.Identity;

namespace FoundBoxSG.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class FoundBoxSGUser : IdentityUser
    {
        public string? FullName { get; set; }
    }
}
