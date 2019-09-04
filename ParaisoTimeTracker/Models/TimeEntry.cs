using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParaisoTimeTracker.Models
{
	public class TimeEntry
	{

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
		public DateTime startTime { get; set; }
		public DateTime endTime { get; set; }
        [Required]
		public DateTime createdInstant { get; set; }
		public DateTime updatedInstant { get; set; }

		public virtual Employee user { get; set; }
	}
}
