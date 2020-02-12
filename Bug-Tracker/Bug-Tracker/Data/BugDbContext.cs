using Bug_Tracker.Controllers;
using Bug_Tracker.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bug_Tracker.Data
{
    public class BugDbContext : DbContext
    {

        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<User> Users { get; set; }

        public BugDbContext(DbContextOptions<BugDbContext> options)
    : base(options)
        { }
        
    }
}
