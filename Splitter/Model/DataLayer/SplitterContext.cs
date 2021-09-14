using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model.DataLayer
{
    public class SplitterContext : DbContext
    {
        public SplitterContext()
        {
            
        }

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Observation> Observations { get; set; }

        public DbSet<Split> Splits { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Cause> Causes { get; set; }
    }
}
