using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void EkleMusteri (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi+":"+ musteri.MusteriSoyadi+":"+musteri.Sehir+":"+musteri.MusteriTel+"Müşteri Sisteme Eklendi");
        }
        public void SilMusteri (Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + ":" + musteri.MusteriSoyadi + ":" + musteri.Sehir + ":" + musteri.MusteriTel + "Müşteri Sistemden Silindi ");
        }
    }
}
