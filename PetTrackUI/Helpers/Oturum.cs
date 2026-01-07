using System;
using PetTrack.Data; // Kullanici sınıfını tanıması için

namespace PetTrackUI.Helpers
{
    public static class Oturum
    {
        // 1. ANLIK HAFIZA: Program açıkken "Kim giriş yaptı?" bilgisini burada tutar.
        public static Kullanici SimdikiKullanici { get; set; }

        // 2. KALICI HAFIZA: "Beni Hatırla" dediyse bilgisayara kaydeder.
        public static void BilgileriHatirla(string kadi, string sifre, bool hatirla)
        {
            if (hatirla)
            {
                Properties.Settings.Default.KullaniciAdi = kadi;
                Properties.Settings.Default.Sifre = sifre;
                Properties.Settings.Default.BeniHatirla = true;
            }
            else
            {
                Properties.Settings.Default.KullaniciAdi = "";
                Properties.Settings.Default.Sifre = "";
                Properties.Settings.Default.BeniHatirla = false;
            }
            Properties.Settings.Default.Save(); // Kaydetmeyi unutma
        }
    }
}