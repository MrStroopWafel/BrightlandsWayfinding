namespace BrightlandsCasus.Models
{
    public class LokaalBedrijf
    {
        public int Id { get; set; }

        public Lokaal lokaal { get; set; }
        public Bedrijf bedrijf { get; set; }
        public int LokaalId { get; set; }
        public int BedijfId { get; set; }
        public string LokaalNummer { get; set; }
    }
}
