using BrightlandsCasus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BrightlandsCasus.Models;

namespace BrightlandsCasus.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Stap> Stappen { get; set; }
        public DbSet<StapConnecties> StapConnecties { get; set; }

        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    builder.Entity<Stap>()
        //        .HasOne(o => o.StapConnecties)
        //        .WithMany(v => v.Stappen)
        //        .HasForeignKey(o => o.stappenConnectieId);
        //}
    }
}