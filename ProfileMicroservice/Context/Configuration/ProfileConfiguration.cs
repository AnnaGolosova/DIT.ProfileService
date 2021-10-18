using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Context.Configuration
{
    public class ProfileConfiguration : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasData(
                new Profile()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "dsf",
                    LastName = "dsf",
                    GenderId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                });
        }
    }
}
