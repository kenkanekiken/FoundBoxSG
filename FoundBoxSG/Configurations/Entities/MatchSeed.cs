using FoundBoxSG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoundBoxSG.Configurations.Entities
{
    public class MatchSeed : IEntityTypeConfiguration<Matches>
    {
        public void Configure(EntityTypeBuilder<Matches> builder)
        {
            builder.HasData(
                new Matches
                {
                    Id = 1,
                    CreatedBy = "John",
                    ModifiedBy = null,
                    DateCreated = DateTime.Now,
                    DateModified = null,
                    ListingId = 1,
                    MatcherUserId = 2,
                },
                new Matches
                {
                    Id = 2,
                    CreatedBy = "Jane",
                    ModifiedBy = null,
                    DateCreated = DateTime.Now,
                    DateModified = null,
                    ListingId = 2,
                    MatcherUserId = 1,
                }
            );
        }
    }
}
