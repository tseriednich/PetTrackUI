using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PetTrack.Data
{
    public class Kullanici
    {
        public int Id { get; set; }

        // string yanına ? koyduk. Artık null olabilir.
        public string? AdSoyad { get; set; }

        public string? KullaniciAdi { get; set; }

        public string? Email { get; set; }

        public string? Sifre { get; set; }
    }
}