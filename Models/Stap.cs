using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightlandsCasus.Models
{
    public class Stap
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StappenBeschrijving { get; set; }
        public int? lokaalId { get; set; }
        public int? stappenConnectieId { get; set; }
        //public StapConnecties StapConnecties { get; set; }
    }
}
