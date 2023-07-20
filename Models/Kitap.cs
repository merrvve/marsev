using System.ComponentModel;

namespace marsev.Models
{
    public class Kitap : BaseEntity
    {
       
        public string? KitapAdi { get; set; }
        public int? Fiyat { get; set; }

        public string? KitapResmi { get; set; }
    }
}
