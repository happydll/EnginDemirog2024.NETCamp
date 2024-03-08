using Business.Concrete;
using Entities.Concrete;
using System;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //degiskenler();

            //Vatandas vatandas1 = new Vatandas();

            //degiskenler1();

            Pharmancy pharmancy1 = new Pharmancy();
            pharmancy1.PharmancyNo = 06548;
            pharmancy1.PharmancyName = "Faruk Eczanesi";
            pharmancy1.PharmancyAddress = "Universiteler Mah,06645,Cankaya";
            pharmancy1.PharmancyCity = "Ankara";

            MinistryOfHealthManager ministryOfHealthManager = new MinistryOfHealthManager(new PharmancyManager());
            ministryOfHealthManager.ShipMask(pharmancy1);

            PttTakeManager pttTakeManager = new PttTakeManager();
            pttTakeManager.TakeMask(pharmancy1);

            //Person1 nesnesine gerçek bilgileri girip mernis sisteminden doğrulama yapabilirsiniz.
            Person person1 = new Person();
            person1.Firstname = "İbrahim Yasin";
            person1.Lastname = "İnan";
            person1.DateOfBirth = 2000;
            person1.NationalIdentity = 123;

            PttGiveManager pttManager = new PttGiveManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        /*
        private static void degiskenler1()
        {
            //Selamver("ibrahim");
            //int sonuc = topla(3,5);


            //diziler
            string ogrenci1 = "İbrahim";
            string ogrenci2 = "Yasin";

            //string[] ogrenciler = new string[3];
            //ogrenciler[0] = "İbrahim";
            //ogrenciler[1] = "Yasin";
            //ogrenciler[2] = "Ali";


            string[] ogrenciler = new string[4];
            ogrenciler[3] = "ilker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            //referance tip
            string[] sehirler = { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = { "Konya", "Tekirdağ", "Antalya" };

            sehirler = sehirler2;
            sehirler[0] = "Adana";
            Console.WriteLine(sehirler2[0]);


            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            //generic koleksiyon

            List<string> yenisehirler = new List<string> { "Ankara", "Istanbul", "Izmir" };
            yenisehirler.Add("Kastamonu");

            // newlediğimiz zaman eski verileri cebe atıyor, newlediğimz zaman yeniliyor, o cebe attıklarını yerine koyuyor,
            // sonradan eklediğimizi de sona ekliyor.


            //
            //Challenge
            //
            //           
            //list omasayıdı bu yapıyı nasıl kurardın?



            foreach (string sehir in yenisehirler)
            {
                Console.WriteLine(sehir);
            }
        }
        */

        /*
        //resharper
        static void Selamver(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int topla(int sayi1 = 5, int sayi2 = 10) //default paramereler en sona yazılır
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
        */

        /*
        private static void degiskenler()
        {
            string message = "hello world";
            double tutar = 100000;
            Console.WriteLine(message);
            // Console.WriteLine("Hello World"); //dont repeat yourself!

            int sayi = 100;
            bool grisyaptimi = false;

            string ad = "ibrahim";
            string soyad = "inan";
            int dogumyili = 2000;
            long tcno = 12345678910;

            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Dogumyili { get; set; }
        public long TcNo { get; set;}

    }*/
    }
}