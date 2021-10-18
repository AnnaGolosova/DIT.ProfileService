using Context.Configuration;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Context
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProfileConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
        }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Gender> Genders { get; set; }
    }
}

