using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ModelsDto
{
    public class UpdateProfileDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string ImageUrl { get; set; }
        public string Gender { get; set; }
    }
}
