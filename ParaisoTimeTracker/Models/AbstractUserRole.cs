using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParaisoTimeTracker.Models
{
    public abstract class AbstractUserRole
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int id { get; set; }
        [Required]
		public DateTime createdInstant { get; set; }
		public DateTime updatedInstant { get; set; }

        [Required]
		public virtual User user { get; set; }
	}
}
