
namespace web.Models
{
    public class Objava
    {
        public int ID { get; set; }
        public required string UporabniskiRacunID { get; set; }
        public required string Ime { get; set; }
        public required string Priimek { get; set; }
        public required string Lokacija { get; set; }
        public required string DelovniCas { get; set; }
        public string? Opis { get; set; }
    }

}