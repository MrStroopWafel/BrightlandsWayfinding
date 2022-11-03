using System.ComponentModel.DataAnnotations;

namespace BrightlandsCasus.Models
{
    public class Lokaal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string LokaalNummer { get; set; }
        public int VerdiepingId { get; set; }
        public int? LokaalBedrijfId { get; set; }
        public Verdieping verdieping { get; set; }
        public LokaalBedrijf? bedrijf { get; set; }
    }
}
