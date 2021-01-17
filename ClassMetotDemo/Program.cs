using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "MERVE";
            musteri1.MusteriSoyadi = "güzel";
            musteri1.MusteriTel = 05303802222;
            musteri1.Sehir = "Adana";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Nurettin";
            musteri2.MusteriSoyadi = "KEMALOĞLU";
            musteri2.MusteriTel = 05555555555;
            musteri2.Sehir = "Erzurum";

            Musteri[] musteriler = new Musteri[]
            { 
                musteri1 ,musteri2
            };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi);
                Console.WriteLine(musteri.MusteriSoyadi);
                Console.WriteLine(musteri.MusteriTel);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine("++++++++++++++++++++++++++++++++++");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.EkleMusteri(musteri1);
            musteriManager.SilMusteri(musteri2);
        }
    }
}
