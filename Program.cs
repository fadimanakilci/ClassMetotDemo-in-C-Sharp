using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();
            musteriManager.Ekle(musteri1);
            Musteri musteri2 = new Musteri();
            musteriManager.Ekle(musteri2);

            Console.WriteLine("\n\n");

            List<Musteri> musteriler = new List<Musteri>() { musteri1, musteri2 };
            musteriManager.Listele(musteriler);

            Console.WriteLine("\n\n________________________________________\n\n");

            Console.WriteLine("Silinecek müşteri ID'sini giriniz: ");
            int Id = Convert.ToInt32(Console.ReadLine());
            musteriManager.Sil(musteriler, Id);

            Console.WriteLine("\n\n");

            musteriManager.Listele(musteriler);


        }
    }
}
