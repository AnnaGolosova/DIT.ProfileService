using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.ModelsDto
{
    public class CreateProfileDto
    {
        public Guid AccountId { get; set; }

        [Required(ErrorMessage = "Firstname is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the firstname is 30 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lastname is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Lastname is 30 characters.")]
        public string LastName { get; set; }

        public int Age { get; set; }
        public Guid ImageId { get; set; }

        public Guid GenderId { get; set; }
    }
}
