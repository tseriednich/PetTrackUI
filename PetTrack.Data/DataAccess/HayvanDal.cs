using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic; // List<> kullanmak için

namespace PetTrack.Data.DataAccess
{
    public class HayvanDal
    {
        // Belirli bir kullanıcıya ait hayvanları getirir
        public List<Hayvan> KullaniciyaGoreGetir(int userId)
        {
            List<Hayvan> hayvanlar = new List<Hayvan>();

            using (MySqlConnection conn = new MySqlConnection(DbHelper.ConnectionString))
            {
                // user_id'ye göre filtreleme yapıyoruz
                string sql = "SELECT * FROM pets WHERE user_id = @uid AND is_active = 1";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uid", userId);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hayvanlar.Add(new Hayvan
                            {
                                Id = Convert.ToInt32(reader["pet_id"]),
                                UserId = Convert.ToInt32(reader["user_id"]),
                                Ad = reader["name"].ToString(),
                                Tur = reader["species"].ToString(),
                                Irk = reader["breed"].ToString(),
                                Cinsiyet = reader["gender"].ToString(),
                                // Tarih null gelebilir, kontrol ediyoruz
                                DogumTarihi = reader["birth_date"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["birth_date"]),
                                FotoYolu = reader["photo_path"].ToString()
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Hayvanlar listelenirken hata: " + ex.Message);
                }
            }
            return hayvanlar;
        }
    }
}
