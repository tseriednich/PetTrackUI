using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetTrack.Data
{
    public static class DbHelper
    {
        // SQL dosyan "pettrack" veritabanını kullanıyor.
        // Eğer yerel sunucunda (XAMPP/WAMP) şifre varsa Pwd= kısmına yaz.
        public static string ConnectionString = "Server=localhost;Database=pettrack;Uid=root;Pwd=;";
    }
}
