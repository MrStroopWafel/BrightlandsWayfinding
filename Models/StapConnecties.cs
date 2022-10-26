using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrightlandsCasus.Models
{
    public class StapConnecties
    {
        [Key]
        public int Id { get; set; }
        public int vanId { get; set; }
        public List<Stap> VolgendeStap { get; set; }
        public List<Stap> Afstand { get; set; }
        public List<Stap> RouteUitleg { get; set; }
        //public virtual ICollection<Stap> Stappen { get; set; }
    }
}
