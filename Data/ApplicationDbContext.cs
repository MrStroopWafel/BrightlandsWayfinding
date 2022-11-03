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
        public DbSet<BrightlandsCasus.Models.Stap> Stap { get; set; }
        public DbSet<BrightlandsCasus.Models.StapConnectie> StapConnectie { get; set; }

        public DbSet<Lokaal> Lokalen { get; set; }
        public DbSet<Verdieping> Verdiepingen { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }

        public DbSet<LokaalBedrijf> lokaalBedrijf { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //import de basis relaties van identity
            base.OnModelCreating(builder);

            //maakt van een fk en vult de list van de stap met alle stappen die dat van Id hebben
            builder.Entity<StapConnectie>()
                .HasOne(c => c.StapFrom)
                .WithMany(s => s.ConnectieStartPoints)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<StapConnectie>()
                .HasOne(c => c.StapTo)
                .WithMany(s => s.ConnectieEnds)
                .OnDelete(DeleteBehavior.NoAction);
            builder.Entity<LokaalBedrijf>()
                .HasKey(x => new
                {
                    x.Id
                });

            builder.Entity<LokaalBedrijf>()
                .HasOne(b => b.bedrijf)
                .WithMany(l => l.Lokalen)
                .HasForeignKey(x => x.BedijfId);

            builder.Entity<LokaalBedrijf>()
                .HasOne(l => l.lokaal)
                .WithOne(b => b.bedrijf)
                .HasForeignKey<LokaalBedrijf>(x => x.LokaalId);

            builder.Entity<Lokaal>()
                .HasOne(v => v.verdieping)
                .WithMany(l => l.Lokalen)
                .HasForeignKey(l => l.VerdiepingId);



            //run de data seeds
            DataSeedStappen(builder);
            DataSeedStappenConnecties(builder);

        }
        protected void DataSeedStappen(ModelBuilder builder)
        {
            builder.Entity<Stap>().HasData(
                new Stap { Id = 1, StappenBeschrijving = "Ingang", LokaalId = null },
                new Stap { Id = 2, StappenBeschrijving = "Trap begaande grond", LokaalId = null },
                new Stap { Id = 3, StappenBeschrijving = "WC", LokaalId = null },
                new Stap { Id = 4, StappenBeschrijving = "Administratie", LokaalId = null },
                new Stap { Id = 5, StappenBeschrijving = "Eerste verdieping lift", LokaalId = null },
                new Stap { Id = 6, StappenBeschrijving = "Lokaal 1", LokaalId = 1 },
                new Stap { Id = 7, StappenBeschrijving = "Zithal", LokaalId = null },
                new Stap { Id = 8, StappenBeschrijving = "1e verdieping", LokaalId = null },
                new Stap { Id = 9, StappenBeschrijving = "1e verdieping gang links", LokaalId = null },
                new Stap { Id = 10, StappenBeschrijving = "1e verdieping gang rechts", LokaalId = null },
                new Stap { Id = 11, StappenBeschrijving = "1e verdieping gang rechtdoor", LokaalId = null },
                new Stap { Id = 12, StappenBeschrijving = "Lokaal 2", LokaalId = 2 },
                new Stap { Id = 13, StappenBeschrijving = "Lokaal 3", LokaalId = 3 },
                new Stap { Id = 14, StappenBeschrijving = "Lokaal 4", LokaalId = 4 },
                new Stap { Id = 15, StappenBeschrijving = "Lokaal 5", LokaalId = 5 },
                new Stap { Id = 16, StappenBeschrijving = "Lokaal 6", LokaalId = 6 }
                );
        }
        protected void DataSeedStappenConnecties(ModelBuilder builder)
        {
            builder.Entity<StapConnectie>().HasData(
                new StapConnectie { Id = 1, StapFromId = 1, StapToId = 2, Afstand = 2, RouteUitelg = "Loop links naar de trap" },
                new StapConnectie { Id = 2, StapFromId = 1, StapToId = 3, Afstand = 3, RouteUitelg = "Loop rechts naar de wc" },
                new StapConnectie { Id = 3, StapFromId = 1, StapToId = 4, Afstand = 2, RouteUitelg = "Loop rechtdoor naar de administratie" },
                new StapConnectie { Id = 4, StapFromId = 1, StapToId = 5, Afstand = 5, RouteUitelg = "Loop links naar de traplift" },
                new StapConnectie { Id = 5, StapFromId = 1, StapToId = 7, Afstand = 1, RouteUitelg = "Loop rechtdoor naar de zithal" },
                new StapConnectie { Id = 6, StapFromId = 2, StapToId = 8, Afstand = 12, RouteUitelg = "loop de trap op" },
                new StapConnectie { Id = 7, StapFromId = 8, StapToId = 9, Afstand = 6, RouteUitelg = "Loop links de gang op" },
                new StapConnectie { Id = 8, StapFromId = 8, StapToId = 10, Afstand = 3, RouteUitelg = "Loop rechts de gang op" },
                new StapConnectie { Id = 9, StapFromId = 8, StapToId = 11, Afstand = 6, RouteUitelg = "Loop rechtdoor de gang op" },
                new StapConnectie { Id = 10, StapFromId = 9, StapToId = 12, Afstand = 8, RouteUitelg = "Open de deur van lokaal 2" },
                new StapConnectie { Id = 11, StapFromId = 9, StapToId = 13, Afstand = 9, RouteUitelg = "Open de deur van lokaal 3" },
                new StapConnectie { Id = 12, StapFromId = 10, StapToId = 14, Afstand = 2, RouteUitelg = "Open de deur van lokaal 4" },
                new StapConnectie { Id = 13, StapFromId = 10, StapToId = 15, Afstand = 4, RouteUitelg = "Open de deur van lokaal 5" },
                new StapConnectie { Id = 14, StapFromId = 11, StapToId = 16, Afstand = 5, RouteUitelg = "Open de deur van lokaal 6" }

                );
        }


        
    }
}