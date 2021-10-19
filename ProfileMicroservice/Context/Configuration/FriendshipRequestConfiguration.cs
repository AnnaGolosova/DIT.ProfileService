using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Context.Configuration
{
    public class FriendshipRequestConfiguration : IEntityTypeConfiguration<FriendshipRequest>
    {
        public void Configure(EntityTypeBuilder<FriendshipRequest> builder)
        {
            builder.HasData(
                new FriendshipRequest()
                {
                    Id = new Guid("ec0b51f1-ed70-407c-b778-90bd968ebbda"),
                    ReceverId = new Guid("dcf7036a-ab3d-4d14-8276-8dcb1f5e2965"),
                    SenderId = new Guid("ab2356a6-702a-4372-9554-7bdd6d111a30"),
                    Date = new DateTime(),
                    Status = "Unread"
                });
        }
    }
}
