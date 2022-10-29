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
        public DbSet<BrightlandsCasus.Models.Stap> Stap { get; set; }
        public DbSet<BrightlandsCasus.Models.StapConnectie> StapConnectie { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //import de basis relaties van identity
            base.OnModelCreating(builder);

            //maakt van een fk en vult de list van de stap met alle stappen die dat van Id hebben
            builder.Entity<StapConnectie>()
                .HasOne(c => c.VanStap)
                .WithMany(s => s.StapConnecties)
                .HasForeignKey(c => c.VanId);

            //testen voor de 2e connectie naar de NaarId en de NaarStap te vullen
            //builder.Entity<StapConnectie>()
            //    .HasOne(c => c.NaarStap)
            //    .WithMany(s => s.ConnectieEndpoints)
            //    .HasForeignKey(c => c.NaarId)
            //    .OnDelete(DeleteBehavior.SetNull);

            ////moet een fk zijn die geen shit in de lijst gooid
            //builder.Entity<StapConnectie>()
            //    .HasOne(c => c.NaarStap)
            //    .WithOne(s => s.Id)
            //    .HasForeignKey(c => c.VanId);

        }
    }
}