using Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class FriendRepository : BaseRepository<Friend>, IFriendRepository
    {
        public FriendRepository(ProfileContext context) : base(context)
        {

        }
    }
}
