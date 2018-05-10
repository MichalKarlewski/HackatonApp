using HackatonData.Models;
using Microsoft.EntityFrameworkCore;
using System;


namespace HackatonData
{
    public class HackatonContext : DbContext
    {
        public HackatonContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Sreg> Sreg { get; set; }
        public DbSet<Kreditor> Kreditor { get; set; }
        public DbSet<Debitor> Debitor { get; set; }
        public DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Status>().HasKey(status => new
            {
                status.Status_SakNr,
                status.Status_LinjeNr
            });
        }
    }
}
