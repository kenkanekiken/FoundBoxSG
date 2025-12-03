using FoundBoxSG.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoundBoxSG.Configurations.Entities
{
    public class UserSeed : IEntityTypeConfiguration<FoundBoxSGUser>
    {
        public void Configure(EntityTypeBuilder<FoundBoxSGUser> builder)
        {
            var hasher = new PasswordHasher<FoundBoxSGUser>();
            builder.HasData(
            new FoundBoxSGUser
            {
                Id = "3781efa7-66dc-47f0-860f-e506d04102e4",
                Email = "admin@localhost.com",
                NormalizedEmail = "ADMIN@LOCALHOST.COM",
                FullName = "Admin User",
                UserName = "admin@localhost.com",
                NormalizedUserName = "ADMIN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "password"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
