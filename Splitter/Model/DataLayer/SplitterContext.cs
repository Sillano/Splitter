using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Splitter.Model.DataLayer
{
    public class SplitterContext : DbContext
    {

        private readonly string dbPath;

        public SplitterContext()
        {
            const Environment.SpecialFolder folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            this.dbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}splitter.db";

            this.Database.EnsureCreated();
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={this.dbPath}");

        public DbSet<Profile> Profiles { get; set; }

        public DbSet<Observation> Observations { get; set; }

        public DbSet<Split> Splits { get; set; }

        public DbSet<Like> Likes { get; set; }

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<Cause> Causes { get; set; }
    }
}
