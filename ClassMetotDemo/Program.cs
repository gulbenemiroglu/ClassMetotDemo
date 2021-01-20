using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Gülben";
            musteri1.Soyad = "Emiroğlu";
            musteri1.Id = "0001";

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Bilge";
            musteri2.Soyad = "Köksal";
            musteri2.Id = "0002";

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Merve";
            musteri3.Soyad = "Sütçü";
            musteri3.Id = "0003";

            Musteri musteri4 = new Musteri();
            musteri4.Ad = "Çisem";
            musteri4.Soyad = "Akman";
            musteri4.Id = "0004";

            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("---------MÜŞTERİ EKLEME----------");
            musteriManager.MusteriEkleme(musteri1);
            musteriManager.MusteriEkleme(musteri2);
            musteriManager.MusteriEkleme(musteri3);
            musteriManager.MusteriEkleme(musteri4);

            Console.WriteLine("---------MÜŞTERİ LİSTELE----------");
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
            musteriManager.MusteriListele(musteri3);
            musteriManager.MusteriListele(musteri4);

            Console.WriteLine("---------MÜŞTERİ SİLME----------");
            musteriManager.MusteriSilme(musteri1);
            musteriManager.MusteriSilme(musteri2);
            musteriManager.MusteriSilme(musteri3);
            musteriManager.MusteriSilme(musteri4);



        }
    }
}
