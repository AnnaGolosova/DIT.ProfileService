using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Models
{
    public class Gender
    {
        [Key]
        public Guid Id { get; set; }

        public string Title { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
