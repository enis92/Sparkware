using System;
using System.ComponentModel.DataAnnotations;

namespace Sparkware.DM {
    public class User {
        public Guid Id { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string LastName { get; set; }

        [Required]
        [StringLength(250, MinimumLength = 2)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
    }
}