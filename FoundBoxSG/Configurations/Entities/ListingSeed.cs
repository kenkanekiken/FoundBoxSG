using FoundBoxSG.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoundBoxSG.Configurations.Entities
{
    public class ListingSeed : IEntityTypeConfiguration<Listings>
    {
        public void Configure(EntityTypeBuilder<Listings> builder)
        {
            builder.HasData(
                new Listings
                {
                    Id = 1,
                    UserId = 1,
                    CreatedBy = "John",
                    ModifiedBy = null,
                    DateCreated = DateTime.Now,
                    DateModified = null,
                    ListingType = "Found",
                    Title = "Found Keys",
                    Description = "Set of car keys with a red keychain",
                    ItemCategory = "Keys",
                    Brand = "N/A",
                    Location = "Marina Bay Sands",
                    UniqueFeatures = "Red keychain with a smiley face",
                    Color = "Silver and Red",
                    Image = null
                },
                new Listings
                {
                    Id = 2,
                    UserId = 2,
                    CreatedBy = "Jane",
                    ModifiedBy = null,
                    DateCreated = DateTime.Now,
                    DateModified = null,
                    ListingType = "Lost",
                    Title = "Lost Wallet",
                    Description = "Black leather wallet",
                    ItemCategory = "Wallet",
                    Brand = "Gucci",
                    Location = "Orchard Road",
                    UniqueFeatures = "Gold emblem",
                    Color = "Black",
                    Image = null
                }
            );
        }
    }
}

