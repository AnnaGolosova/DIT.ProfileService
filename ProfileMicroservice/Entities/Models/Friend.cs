using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.Models
{
    public class Friend
    {
        public Guid ProfileId { get; set; }

        public Guid FriendId { get; set; }
        [ForeignKey("FriendId")]
        public Profile Profile { get; set; }
    }
}
