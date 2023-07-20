namespace marsev.Models
{
    public class Etkinlik : BaseEntity
    {
       
        public string? EtkinlikAdi { get; set; }

        public string? EtkinlikTuru { get; set; }

        public string? EtkinlikTipi { get; set; }

        public DateTime EtkinlikTarihi { get; set; }

        public string? Aciklama { get; set; }
        public string? Detay { get; set; }

    
    }
}
