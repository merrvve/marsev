namespace marsev.Models
{
    public class KitapTalepModel : BaseEntity
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string email { get; set; }
        public string telefonno { get; set; }
        public string adres { get; set; }
        public string kitap { get; set; }
        public int kitapId { get; set; }

    }
}
