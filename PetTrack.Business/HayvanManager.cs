using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetTrack.Data;
using PetTrack.Data.DataAccess;

namespace PetTrack.Business
{
    public class HayvanManager
    {
        private HayvanDal _hayvanDal = new HayvanDal();

        public List<Hayvan> KullanicininHayvanlariniGetir(int userId)
        {
            // İleride burada "Kullanıcının üyeliği aktif mi?" gibi kontroller yapılabilir.
            return _hayvanDal.KullaniciyaGoreGetir(userId);
        }
    }
}