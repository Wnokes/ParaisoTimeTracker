using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParaisoTimeTracker.Models
{
    public class Employee : AbstractUserRole
    {
        public double payRate { get; set; } // this should probably be extracted into some kind of abstract class or something that can be used later if we want to implement piece rate or something

        public virtual ICollection<TimeEntry> timeEntries { get; set; }
        [Required]
        public virtual Company company { get; set; }
	}
}
