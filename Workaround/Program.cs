using Business.Concrete;
using Entities.Concrete;

namespace Workaround
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();
            int sonuc = Topla(3, 5);

            string ogrencil = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrencil); 
            //Console.WriteLine(ogrenci2); 
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Engin";
            Person person2 = new Person();
            person2.FirstName = "Murat";
            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" }; yeniSehirler1.Add(item: "Adana 1");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }

        //private static void Degiskenler()
        //{
        //    string mesaj = "Merhaba";
        //    double tutar = 100000; //db den gelir
        //    int savi = 100;
        //    bool girisYapmisMi = false;
        //    string ad = "Engin";
        //    string soyad = "Demiroğ";
        //    int dogumYili = 1985;
        //    long toNo = 12345678910;
        //    Console.WriteLine(tutar * 1.18);
        //    Console.WriteLine(tutar * 1.18);
        //}
        //public class Vatandas
        //{
        //    public string Ad { get; set; }
        //    public string Soyad { get; set; }
        //    public int DogunYili { get; set; }
        //    public long ToNo { get; set; }
        //}
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }
        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine();
            return sonuc;
        }
    }
}