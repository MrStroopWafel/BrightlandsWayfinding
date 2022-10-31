using BrightlandsCasus.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrightlandsCasus.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<LokaalBedrijf>()
                .HasKey(x => new
                {
                    x.Id
                });

            modelBuilder.Entity<LokaalBedrijf>()
                .HasOne(b => b.bedrijf)
                .WithMany(l => l.Lokalen)
                .HasForeignKey(x => x.BedijfId);

            modelBuilder.Entity<LokaalBedrijf>()
                .HasOne(l => l.lokaal)
                .WithOne(b => b.bedrijf)
                .HasForeignKey<LokaalBedrijf>(x => x.LokaalId);

            modelBuilder.Entity<Lokaal>()
                .HasOne(v => v.verdieping)
                .WithMany(l => l.Lokalen)
                .HasForeignKey(l => l.VerdiepingId);
        }

        public DbSet<Lokaal> Lokalen { get; set; }
        public DbSet<Verdieping> Verdiepingen { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }

        public DbSet<LokaalBedrijf> lokaalBedrijf { get; set; }
    }
}