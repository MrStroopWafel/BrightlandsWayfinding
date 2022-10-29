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
    }
}