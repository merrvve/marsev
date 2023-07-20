using marsev.Models;

namespace marsev.Services
{
    public class ContactFormService
    {
        string path;
        public ContactFormService()
        {
            try
            {
                path = $"~/data/iletisim.csv";
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

        public void ContactEkle(FormModel fm)
        {
            try
            {
                string yenicontact = "'" + fm.isim + "','" + fm.soyisim + "','" + fm.mail +
                    "','" + fm.mesaj + "','";
                using (StreamWriter stream = new StreamWriter(path, true, System.Text.Encoding.UTF8))
                {
                    stream.WriteLine(yenicontact);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
