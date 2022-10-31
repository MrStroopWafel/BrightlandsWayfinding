using System.ComponentModel.DataAnnotations;

namespace BrightlandsCasus.Models
{
    public class Verdieping
    {
        [Key]
        public int Id { get; set; }
        public string Beschrijving { get; set; }
        public ICollection<Lokaal> Lokalen { get; set; }
    }
}
