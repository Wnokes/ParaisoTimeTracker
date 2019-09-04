using System;
using System.ComponentModel.DataAnnotations;

namespace ParaisoTimeTracker.Models
{
    public class CompanyAdmin : AbstractUserRole 
    {
        [Required]
		public virtual Company company { get; set; }
	}
}
