using System;
namespace ParaisoTimeTracker.Models
{
    public class Employee
    {
        public int id { get; set; }
        public double payRate { get; set; }
		public DateTime createdInstant { get; set; }
		public DateTime updatedInstant { get; set; }
	}
}
