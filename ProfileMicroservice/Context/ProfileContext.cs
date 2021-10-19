using Context.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Context
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new FriendConfiguration());
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Friend> Friends { get; set; }
    }
}

