using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class Friend
    {
        public Guid ProfileId { get; set; }
        public Guid FriendId { get; set; }
    }
}
