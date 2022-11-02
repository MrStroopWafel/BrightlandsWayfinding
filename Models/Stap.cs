using System.ComponentModel.DataAnnotations;

namespace BrightlandsCasus.Models
{
    public class Stap
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StappenBeschrijving { get; set; }
        public int? LokaalId { get; set; }
        public virtual ICollection<StapConnectie> ConnectieStartPoints { get; set; }
        public virtual ICollection<StapConnectie> ConnectieEnds { get; set; }
    }
}
