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
                     TotalListings = 1,
                     ProfileImageUrl = null,
                     Nationality = "Singaporean",
                     Region = "Tampines"
                 },
                 new AppUser
                 {
                     Id = 2,
                     CreatedBy = "Jane",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     TotalListings = 1,
                     ProfileImageUrl = null,
                     Nationality = "Singaporean",
                     Region = "Bedok"
                 }
             );
        }
    }
}
