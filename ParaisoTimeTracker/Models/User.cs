using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParaisoTimeTracker.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public String accountNumber { get; set; }
        [Required]
        public String password { get; set; }
        [Required]
        public String firstName { get; set; }
        [Required]
        public String lastName { get; set; }
        public bool isActive { get; set; }
        [Required]
        public DateTime createdInstant { get; set; }
        public DateTime updatedInstant { get; set; }

        public ICollection<AbstractUserRole> userRoles { get; set; }
    }
}
