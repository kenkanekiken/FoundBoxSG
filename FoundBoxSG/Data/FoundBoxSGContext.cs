using FoundBoxSG.Configurations.Entities;
using FoundBoxSG.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoundBoxSG.Data
{
    public class FoundBoxSGContext(DbContextOptions<FoundBoxSGContext> options) : IdentityDbContext<FoundBoxSGUser>(options)
    {
        public DbSet<FoundBoxSG.Domain.AppUser> AppUser { get; set; } = default!;
        public DbSet<FoundBoxSG.Domain.Listings> Listings { get; set; } = default!;
        public DbSet<FoundBoxSG.Domain.Matches> Matches { get; set; } = default!;
        public DbSet<FoundBoxSG.Domain.Messages> Messages { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ListingSeed());
            builder.ApplyConfiguration(new MatchSeed());
            builder.ApplyConfiguration(new MessageSeed());
            builder.ApplyConfiguration(new AppUserSeed());
            builder.ApplyConfiguration(new RoleSeed());
            builder.ApplyConfiguration(new UserSeed()); 
            builder.ApplyConfiguration(new UserRoleSeed());
        }
    }
}
