using System;
using Microsoft.EntityFrameworkCore;
using ParaisoTimeTracker.Models;

namespace ParaisoTimeTracker.Services
{
    public class TimeTrackerDbContext : DbContext
    {
        public TimeTrackerDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyAdmin> CompanyAdmins { get; set; }
        public virtual DbSet<Employee> Employees{ get; set; }
        public virtual DbSet<ParaisoAdmin> ParaisoAdmins{ get; set; }
        public virtual DbSet<TimeEntry> TimeEntries{ get; set; }
        public virtual DbSet<User> Users{ get; set; }
    }
}
