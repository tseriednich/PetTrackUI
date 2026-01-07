using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrack.Data;
using PetTrack.Data.DataAccess;


namespace PetTrack.Business
{
    public class KullaniciManager
    {
        private KullaniciDal _kullaniciDal = new KullaniciDal();

        public Kullanici GirisYap(string email, string sifre)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                throw new Exception("Lütfen e-posta ve şifre alanlarını doldurun.");
            }

            // Veritabanına soruyoruz
            Kullanici? user = _kullaniciDal.LoginKontrol(email, sifre);

            if (user == null)
            {
                throw new Exception("Hatalı e-posta veya şifre!");
            }

            return user;
        }
    }
}
