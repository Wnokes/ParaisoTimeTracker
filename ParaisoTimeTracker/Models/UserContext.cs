using System;
using Microsoft.EntityFrameworkCore;
namespace ParaisoTimeTracker.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            :base(options)
        {
            UserItems.Add(new UserItem { Name = "sam" });
        }

        public DbSet<UserItem> UserItems { get; set; }
    }
}
