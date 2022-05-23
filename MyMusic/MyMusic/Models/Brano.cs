namespace MyMusic.Models
{
    public class Brano
    {
        public int IdBrano { get; set; }
        public string Titolo{ get; set; }
        public DateTime AnnoUscita { get; set; }
        public decimal Durata { get; set; }
        public string Genere { get; set; }
    }
}