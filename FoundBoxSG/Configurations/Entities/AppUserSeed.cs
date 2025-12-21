using FoundBoxSG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoundBoxSG.Configurations.Entities
{
    public class AppUserSeed : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasData(
                 new AppUser
                 {
                     Id = 1,
                     CreatedBy = "John",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     ProfileImageUrl = "/user.png",
                     Nationality = "Singaporean",
                     Region = "Tampines",
                     AspNetUserId = "4b3a8d1e-2f5c-4e7a-9b0d-1f2g3h4i5j6k"
                 },
                 new AppUser
                 {
                     Id = 2,
                     CreatedBy = "Jane",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     ProfileImageUrl = "/user.png",
                     Nationality = "Singaporean",
                     Region = "Bedok",
                     AspNetUserId = "9c5f2b8a-1d6e-3c9b-7a4f-0e1d2c3b4a59"
                 },
                 new AppUser 
                 {
                     Id = 3,
                     CreatedBy = "Admin",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     ProfileImageUrl = "/user.png",
                     Nationality = "Singaporean",
                     Region = "Singapore",
                     AspNetUserId = "3781efa7-66dc-47f0-860f-e506d04102e4"
                 }
             );
        }
    }
}
