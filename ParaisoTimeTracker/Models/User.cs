using System;
namespace ParaisoTimeTracker.Models
{
    public class User
    {
        public int id { get; set; }
        public String accountNumber { get; set; }
        public String password { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public DateTime createdInstant { get; set; }
        public DateTime updatedInstant { get; set; }
    }
}
