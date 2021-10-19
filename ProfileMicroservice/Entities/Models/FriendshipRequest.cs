using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
    public class FriendshipRequest
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceverId { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
    }
}
