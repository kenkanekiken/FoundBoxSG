using FoundBoxSG.Domain;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoundBoxSG.Configurations.Entities
{
    public class MessageSeed : IEntityTypeConfiguration<Messages>
    {
        public void Configure(EntityTypeBuilder<Messages> builder)
        {
            builder.HasData(
                 new Messages
                 {
                     Id = 1,
                     CreatedBy = "John",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     SenderUserId = 1,
                     ReceiverUserId = 2,
                     MatchId = 1,
                     Content = "Hello! Is this item still available?"
                 },
                 new Messages
                 {
                     Id = 2,
                     CreatedBy = "Jane",
                     ModifiedBy = null,
                     DateCreated = DateTime.Now,
                     DateModified = null,
                     SenderUserId = 2,
                     ReceiverUserId = 1,
                     MatchId = 1,
                     Content = "Yes, it is still available. Would you like to arrange a pickup?",
                 }
             );
        }
    }
}
