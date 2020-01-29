using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Data
{
    public class BugContext : DbContext
    {
        public BugContext(DbContextOptions<BugContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Bug> Bugs { get; set; }
    }
}
