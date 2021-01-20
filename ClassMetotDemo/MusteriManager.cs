using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+ " müşterimiz sistemimize eklenmiştir.");
        }

        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri AD SOYAD: "+ musteri.Ad + " " + musteri.Soyad + " Müşteri ID: "+musteri.Id);
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" "+musteri.Soyad+ " müşterimiz sistemimizden silinmiştir.");
        }

    }
}
