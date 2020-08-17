using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LoggerAssistant.API.Model;

namespace LoggerAssistant.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        //Add DbSets Here
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Relations

            //One Account has many Logs --> We can expand this later, so there could be an account hierarki.
            modelBuilder.Entity<Account>()
                .HasMany(c => c.Logs)
                .WithOne(e => e.Account);
        }
    }
}
