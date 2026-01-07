using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PetTrackUI.Helpers
{
    public static class Db
    {
        private static readonly string _connStr =
            "Server=localhost;Port=3306;Database=pettrack;Uid=root;Pwd=;SslMode=None;";

        public static MySqlConnection GetConnection()
            => new MySqlConnection(_connStr);
    }
}

