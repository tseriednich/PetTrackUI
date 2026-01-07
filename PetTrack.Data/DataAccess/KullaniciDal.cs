using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace PetTrack.Data.DataAccess
{
    public class KullaniciDal
    {
        // "Kullanici" yerine "Kullanici?" yazıyoruz
        public Kullanici? LoginKontrol(string email, string sifre)
        {
            Kullanici? user = null;

            using (MySqlConnection conn = new MySqlConnection(DbHelper.ConnectionString))
            {
                // DİKKAT: SQL tablondaki sütun isimlerini buraya yazdım.
                // Şimdilik şifreyi düz metin (hashsiz) kontrol ediyoruz.
                string sql = "SELECT * FROM users WHERE email=@email AND password_hash=@pass";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@pass", sifre);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Kullanici
                            {
                                Id = Convert.ToInt32(reader["user_id"]),
                                AdSoyad = reader["full_name"].ToString(),
                                KullaniciAdi = reader["username"].ToString(),
                                Email = reader["email"].ToString(),
                                Sifre = reader["password_hash"].ToString()
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanı hatası: " + ex.Message);
                }
            }
            return user;
        }
    }
}