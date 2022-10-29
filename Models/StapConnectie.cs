using System.ComponentModel.DataAnnotations;

namespace BrightlandsCasus.Models
{
    public class StapConnectie
    {
        [Key]
        public int Id { get; set; }
        public int VanId { get; set; }
        public int NaarId { get; set; }
        public int Afstand { get; set; }
        public string RouteUitelg { get; set; }
        public Stap VanStap { get; set; }
        //public Stap NaarStap { get; set; }
    }
}
