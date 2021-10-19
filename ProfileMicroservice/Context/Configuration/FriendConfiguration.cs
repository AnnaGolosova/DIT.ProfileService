using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Context.Configuration
{
    public class FriendConfiguration : IEntityTypeConfiguration<Friend>
    {
        public void Configure(EntityTypeBuilder<Friend> builder)
        {
            builder.HasData(
                new Friend()
                {
                    ProfileId = new Guid("07641816-9097-451e-8aef-9f24c5786c20"),
                    FriendId = new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965")
                },
                new Friend()
                {
                    ProfileId = new Guid("07641816-9097-451e-8aef-9f24c5786c20"),
                    FriendId = new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30")
                });
        }
    }
}
