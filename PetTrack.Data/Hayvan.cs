using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace PetTrack.Data
{
    public class Hayvan
    {
        public int Id { get; set; }           // pets -> pet_id
        public int UserId { get; set; }       // pets -> user_id
        public string? Ad { get; set; }       // pets -> name
        public string? Tur { get; set; }      // pets -> species
        public string? Irk { get; set; }      // pets -> breed
        public string? Cinsiyet { get; set; } // pets -> gender
        public DateTime DogumTarihi { get; set; } // pets -> birth_date
        public string? Notlar { get; set; }   // pets -> notes
        public string? FotoYolu { get; set; } // pets -> photo_path
        public bool AktifMi { get; set; }     // pets -> is_active
    }
}
