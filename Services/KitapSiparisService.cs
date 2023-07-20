using marsev.Models;
using System.Security.Cryptography.X509Certificates;

namespace marsev.Services
{
    public class KitapSiparisService
    {
        string path;
        public KitapSiparisService()
        {
            try
            {
                path = $"~/data/kitap-siparis.csv";
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

        public void SiparisEkle(KitapTalepModel ktm)
        {
            try
            {
                string yenisiparis = "'" + ktm.isim + "','" + ktm.soyisim +"','" + ktm.email +
                    "','" + ktm.telefonno + "','" + ktm.adres + "','" + ktm.kitap + "',";
                using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.UTF8))
                {
                    stream.WriteLine(yenisiparis);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
