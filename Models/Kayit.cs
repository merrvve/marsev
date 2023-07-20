namespace marsev.Models
{
    public class Kayit : BaseEntity
    {
        public Kayit()
        {
            this.Odeme = "Bekleniyor";
           
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Kurum { get; set; }
        public string Sehir { get; set; }
        public string Meslek { get; set; }
        public string Kurs { get; set; }
        public string Odeme { get; set; }
    }
}
