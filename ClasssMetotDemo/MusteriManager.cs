using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasssMetotDemo
{
    class MusteriManager
    {
        private List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Yeni müşteri eklendi: " + musteri.Ad + " " + musteri.Soyad);
        }

        public void MusteriListele()
        {
            Console.WriteLine("Müşteri Listesi:");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("Id: " + musteri.Id);
                Console.WriteLine("Ad: " + musteri.Ad);
                Console.WriteLine("Soyad: " + musteri.Soyad);
                Console.WriteLine("Adres: " + musteri.Adres);
                Console.WriteLine("Kredi Notu: " + musteri.KrediNotu);
                Console.WriteLine("------------------");
            }
        }

        public void MusteriSil(int id)
        {
            Musteri musteri = musteriler.Find(m => m.Id == id);
            if (musteri == null)
            {
                Console.WriteLine("Müşteri bulunamadı.");
                return;
            }
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri silindi: " + musteri.Ad + " " + musteri.Soyad);
        }


        //        Yukarıdaki örnekte MusteriManager isimli bir sınıf tanımlanmıştır.Bu sınıfın içinde,
        //        "musteriler" adlı bir liste yer almaktadır.
        //        Bu liste, Musteri nesnelerini tutmak için kullanılmaktadır.

        //Sınıfın içinde üç adet metot yer almaktadır:

        //"MusteriEkle" metodu, bir Musteri nesnesi alarak, bu nesneyi "musteriler" listesine ekler.
        //Ekleme işlemi tamamlandıktan sonra,
        //yeni müşterinin adı ve soyadı ekrana yazdırılır.

        //"MusteriListele" metodu, "musteriler" listesindeki tüm müşterilerin bilgilerini ekrana yazdırır.

        //"MusteriSil" metodu, bir id değeri alarak, bu id'ye sahip müşteriyi "musteriler" listesinden siler.
        //Silme işlemi tamamlandıktan sonra, silinen müşterinin adı ve soyadı ekrana yazdırılır.
        //Eğer silinecek müşteri bulunamazsa, "Müşteri bulunamadı." mesajı ekrana yazdırılır.

        //Örneğin, aşağıdaki kod parçası ile MusteriManager sınıfı kullanılabilir:

        //MusteriManager musteriManager = new MusteriManager();

        // Yeni müşteri ekleme
        // Musteri musteri1 = new Musteri() { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz", Adres = "İstanbul", KrediNotu = 750 };
        // Musteri musteri2 = new Musteri() { Id = 2, Ad = "Ayşe", Soyad = "Kara", Adres = "Ankara", KrediNotu = 800 };
        // musteriManager.MusteriEkle(musteri1);
        // musteriManager.MusteriEkle(musteri2);

        // Müşteri listeleme
        // musteriManager.MusteriListele();

        // Müşteri silme
        // musteriManager.MusteriSil(2);

        // Güncellenmiş müşteri listesi
        // musteriManager.MusteriListele();

        //Yukarıdaki kod parçasında, öncelikle MusteriManager sınıfından bir nesne oluşturulmuştur.
        //Daha sonra, iki adet Musteri nesnesi oluşturulmuş
        //ve bu nesneler "MusteriEkle" metodu ile "musteriler" listesine eklen
    }
}
