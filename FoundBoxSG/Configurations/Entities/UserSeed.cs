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
            },
            new FoundBoxSGUser
            {
                Id = "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k",
                Email = "John@localhost.com",
                NormalizedEmail = "JOHN@LOCALHOST.COM",
                FullName = "John Kindleson",
                UserName = "John@localhost.com",
                NormalizedUserName = "JOHN@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "password"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            },
            new FoundBoxSGUser
            {
                Id = "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59",
                Email = "Jane@localhost.com",
                NormalizedEmail = "JANE@LOCALHOST.COM",
                FullName = "Jane Kindleberry",
                UserName = "Jane@localhost.com",
                NormalizedUserName = "JANE@LOCALHOST.COM",
                PasswordHash = hasher.HashPassword(null, "password"),
                EmailConfirmed = true // Set to true, otherwise you won't be able to login
            }
            );
        }
    }
}
