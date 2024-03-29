﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParaisoTimeTracker.Models
{
	public class Company
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public String companyName { get; set; }
        [Required]
		public DateTime createdInstant { get; set; }
		public DateTime updatedInstant { get; set; }

        public ICollection<AbstractUserRole> userRoles { get; set; }
	}
}
