using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        int j=1;
        public void Ekle(Musteri ms)
        {
            Console.WriteLine(j+ ". Müşterinin Id'sini giriniz:");
            ms.ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(j+ ". Müşterinin Adını Giriniz:");
            ms.Ad = Console.ReadLine();
            Console.WriteLine(j+ ". Müşterinin Soyadını Giriniz:");
            ms.Soyad = Console.ReadLine();
            Console.WriteLine(j+ ". Müşterinin Yaşını Giriniz:");
            ms.Yas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(j+ ". Müşterinin Bakiyesini Giriniz:");
            ms.Bakiye = float.Parse(Console.ReadLine());
            j++;
        }

        public void Sil(List<Musteri> musteriler, int id)
        {
            for (var i = 0; i < musteriler.Count; i++)
            {
                Musteri musteri = musteriler[i];
                if (musteri.ID == id)
                {
                    musteriler.RemoveAt(i);
                }


            }
        }
        public void Listele(List<Musteri> musteriler)
        {
            int i = 1;
            foreach (Musteri ms in musteriler)
            {
                Console.WriteLine("________________________________________\n");
                Console.Write(i+ ". Müşterinin ID'si: " +ms.ID+ "\n" +i+ ". Müşterinin Adı: " + ms.Ad + "\n" +i+ ". Müşterinin Soyadı: " +ms.Soyad+ "\n");
                Console.Write(i + ". Müşterinin Yaşı: " + ms.Yas + "\n" + i + ". Müşterinin Bakiyesi: " + ms.Bakiye + "\n");
                i++;
            }
        }
    }
}
