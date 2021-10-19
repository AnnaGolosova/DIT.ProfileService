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
                    Id = new Guid("07641816-9097-451e-8aef-9f24c5786c20"),
                    FirstName = "asdasd",
                    LastName = "asdasd",
                    GenderId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                new Profile()
                {
                    Id = new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"),
                    FirstName = "qweqwe",
                    LastName = "qweqwe",
                    GenderId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                },
                new Profile()
                {
                    Id = new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"),
                    FirstName = "dsfdsf",
                    LastName = "dsfdsf",
                    GenderId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
                });
        }
    }
}