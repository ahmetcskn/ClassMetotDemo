using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "Ahmet Coşkun";
            musteri1.yas = 16;
            musteri1.id = 2005;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "Mehmet Kasımoğlu";
            musteri2.yas = 11;
            musteri2.id = 31;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "Ahmet F. Karasu";
            musteri3.yas = 16;
            musteri3.id = 52;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager metodlar = new MusteriManager();

            Console.WriteLine("####################################\n");
            Console.WriteLine("Müşteri ekleme :");
            metodlar.musteriEkle(musteri3);
            Console.WriteLine("\n###################################");


            Console.WriteLine("#####################################\n");
            Console.WriteLine("Müşteri silme :");
            metodlar.musteriSil(musteri2);
            Console.WriteLine("\n###################################");


            Console.WriteLine("####################################\n");
            Console.WriteLine("Müşteri listeleme :");
            foreach (var musteri in musteriler)
            {
                metodlar.musteriListele(musteri);
                Console.WriteLine("-----------");
            }
            Console.WriteLine("\n####################################");







        }
    }
}
