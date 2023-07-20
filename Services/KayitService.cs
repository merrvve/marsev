using marsev.Models;

namespace marsev.Services
{
    public class KayitService
    {
        string path;
        public KayitService()
        {
            try
            {
                path = $"~/data/kayit.csv";
                if (!File.Exists(path))
                {
                    using (File.Create(path)) { };

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }

        public void KayitEkle(Kayit km)
        {
            try
            {
                string yeniKayit = "'" + km.Adi + "','" + km.Soyadi + "','" + km.Email + "','" + km.Telefon + "','"+ km.Kurum + "','" + km.Sehir + "','"+ km.Meslek +"','";
                using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.UTF8))
                {
                    stream.WriteLine(yeniKayit);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
