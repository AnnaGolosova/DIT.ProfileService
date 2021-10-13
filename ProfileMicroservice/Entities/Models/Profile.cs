using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Profile
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Guid ImageId { get; set; }

        public Guid GenderId { get; set; }

        [ForeignKey("GenderId")]
        public Gender Gender { get; set; }
    }
}
