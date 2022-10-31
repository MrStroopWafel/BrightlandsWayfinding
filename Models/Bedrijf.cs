using System.ComponentModel.DataAnnotations;

namespace BrightlandsCasus.Models
{
    public class Bedrijf
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Naam { get; set; }
        public ICollection<LokaalBedrijf> Lokalen { get; set; }
    }
}
