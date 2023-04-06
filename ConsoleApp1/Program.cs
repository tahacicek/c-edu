using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Erişim belirleyiciler (Access Modifiers) - Public, Private, Protected, Internal
            // Public - Her yerden erişilebilir.
            // Private - Sadece tanımlandığı class içerisinden erişilebilir.
            // Protected - Tanımlandığı class ve o class'ın miras aldığı classlardan erişilebilir.
            // Internal - Tanımlandığı assembly içerisinden erişilebilir.

            // Örnek: public int sayi = 10; // public erişim belirleyicisi ile tanımlanan değişken her yerden erişilebilir.
             
            Musteri musteri1 = new Musteri();
            musteri1.musteriAdi = "Ahmet";
            musteri1.musteriSoyadi = "Yılmaz";
            //musteri1.Yas = 25; // private erişim belirleyicisi ile tanımlanan değişken sadece tanımlandığı class içerisinden erişilebilir.
            musteri1.musteriBilgileriGoster();
            //musteri1.musteriSoyadiGoster("Yılmaz"); // private erişim belirleyicisi ile tanımlanan metot sadece tanımlandığı class içerisinden erişilebilir.
            //Araba araba1 = new Araba(4, "BMW", "Siyah");
            //Console.WriteLine("Araba markası: " + araba1.arabaMarkasi + " - " + " Araba Rengi: " + araba1.arabaRengi + " - " + " Araba Kapı Sayısı: " + araba1.kapiSayisi);
            //Araba araba1 = new Araba();
            //araba1.arabaMarkasi = "BMW";
            //araba1.arabaRengi = "Siyah";
            //araba1.kapiSayisi = 4;
            //araba1.KapilariKapat();
            //araba1.Calistir();
            //Console.WriteLine("Araba markası: " + araba1.arabaMarkasi + " - " + " Araba Rengi: " + araba1.arabaRengi + " - " + " Araba Kapı Sayısı: " + araba1.kapiSayisi);
            //araba1.Dur();

            // Yapıcı Metotlar (Constructor) Classlardan nesne oluşturulduğunda çalışan metotlara
            // yapıcı metot denir, geriye değer döndürmezler.

            // Yapıcı metotlar class ismiyle aynı isimde olmalıdır.
            // Yapıcı metotlar geriye değer döndürmezler.
            // Yapıcı metotlar parametre alabilir.
            // Yapıcı metotlar overload edilebilir.
            // Yapıcı metotlar class içerisinde tanımlanır.

            // örnek: public Araba() { } // boş yapıcı metot.
            // örnek: public Araba(int kapiSayisi, string arabaMarkasi, string arabaRengi) { } // parametreli yapıcı metot.



            //int a = 500; // int
            //byte b = (byte)a; // a'yı byte'a çevirdik.
            //Console.WriteLine(b.GetType() + " = " + b); // byte

            //string a = "200"; // string
            //string b = "200"; // string
            ///*int c =  Convert.ToInt32(a) + Convert.ToInt32(b);*/ // a'yı int'e çevirdik. // birinci yol.
            //int d = int.Parse(a) + int.Parse(b); // a'yı int'e çevirdik. // ikinci yol.
            ////ikisi de aynı işi yapıyor.
            //Console.WriteLine(d.GetType() + " = " + d); // int
            //byte b = Convert.ToByte(a); // a'yı byte'a çevirdik.

            //int a = 500;
            //int b = 200;
            //int c = a + b;

            ///*string c = a.ToString() + b.ToString();*/ // a'yı string'e çevirdik. // birinci yol.
            //string d = $"{a}{b}"; // ikinci yol.
            //string e = string.Format("{0}{1}{2}", a, b, c); // üçüncü yol.

            //Console.WriteLine(e.GetType() + " = " + e); // string

            //Console.WriteLine("Lütfen ilk sayıyı giriniz");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Sayıların toplamı: " + (a + b));

            //Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            //Console.WriteLine("1- Bakiye Sorgulama");
            //Console.WriteLine("2- Para Çekme");
            //Console.WriteLine("3- Para Yatırma");

            //int secim = int.Parse(Console.ReadLine());
            //if(secim == 1)
            //{
            //    Console.WriteLine("Bakiyeniz: 1000 TL");
            //}
            //else if (secim == 2)
            //{
            //  Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz.");
            //  int tutar = int.Parse(Console.ReadLine());
            //  if(tutar > 1000)
            //    {
            //        Console.WriteLine("Yetersiz bakiye.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Para başarıyla çekildi. Yeni bakiyeniz: " + (1000 - tutar));
            //    }
            //}else if(secim == 3)
            //{
            //    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz.");
            //    int ekstra = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Para başarıyla yatırıldı. Yeni bakiyeniz: " + (ekstra + 1000));
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı seçim yaptınız.");
            //}

            //int a = 0;
            //do
            //{
            //    Console.WriteLine(a);
            //    a++;
            //} while (a < 11);
            //    Console.WriteLine(a);

            //int[] sayilar = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            //Console.WriteLine(sayilar[2]);

            //string[] isimler = new string[3];
            //isimler[0] = "Ahmet";
            //isimler[1] = "Mehmet";
            //isimler[2] = "Ali";

            //Console.WriteLine(isimler[0]);

            //string[] isimler =
            //{
            //    "Ahmet",
            //    "Mehmet",
            //    "Ali"
            //};

            //Console.WriteLine("Lütfen İsminizi Giriniz. Gerekli kontrol sağlanacaktır.");

            //string isim = Console.ReadLine();

            //for (int i = 0; i < isimler.Length; i++)
            //{
            //    if (isimler[i] == isim)
            //    {
            //        Console.WriteLine("Hoşgeldiniz " + isimler[i]);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Kullanıcı bulunamadı.");
            //        break;
            //    }
            //}

            //int[] notlar = new int[2];

            //for (int i = 0; i < notlar.Length; i++)
            //{
            //    Console.WriteLine("Lütfen " + (i + 1) + ". notu giriniz.");
            //    notlar[i] = int.Parse(Console.ReadLine());
            //}

            //int ortalama = (notlar[0] + notlar[1]) / 2;
            //if (ortalama >= 50)
            //{
            //    Console.WriteLine("Tebrikler geçtiniz.");
            //}
            //else
            //{
            //    Console.WriteLine("Maalesef kaldınız.");
            //}

            //string[] isimler = { "Ahmet", "Ali", "Mehmet" };

            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}

            //int[] sayilar = { 1, 2, 9, 4, 4, 6, 4, 8, 9, 8 };
            //Console.WriteLine("Lütfen bir sayı giriniz");

            //int sayi = int.Parse(Console.ReadLine());
            //int adet = 0;
            //foreach (var item in sayilar)
            //{
            //    if (sayi == item)
            //    {
            //        adet++;

            //    }

            //}
            //if (adet == 0)
            //{
            //    Console.WriteLine("Sayı bulanamadı");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı bulundu. Toplam: " + adet);
            //}
            //string selamlar = "Selamünaleyküm";
            //int sayi1 = 40;
            //int sayi2 = 90;
            //SelamVer();
            //SelamAl(selamlar);
            //Notlar(sayi1, sayi2);

            //int DonenDeger = ToplamaYap(40, 70);
            //if(DonenDeger == 0)
            //{
            //    Console.WriteLine("");
            //}
            //else
            //{
            //    Console.WriteLine("Değer : "+ DonenDeger);
            //}

            //string isimler = Isimler("Taha", "Ahmet");
            //Console.WriteLine(isimler);
            //Console.WriteLine("Lütfen karesini almak istediğiniz sayıyı girini.");
            //int deger = int.Parse(Console.ReadLine());
            //int degerler = Karesi(deger);
            //Console.WriteLine("Sayının karesi :" + degerler);
            //Console.WriteLine("Sayıyı giriniz.");
            //int deger = int.Parse(Console.ReadLine());
            //int sonuc = TekCift(deger);

            //int tip = deger % 2;
            //if (tip == 1)
            //{
            //    Console.WriteLine("Sayı tektir: " + deger);
            //}
            //else
            //{
            //    Console.WriteLine("Sayı çifttir: " + deger);
            //}

            //Console.WriteLine("Lütfen birinci sayıyı giriniz.");
            //int deger1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Lütfen ikinci sayıyı giriniz.");
            //int deger2 = int.Parse(Console.ReadLine());

            //int sonuc = BuyukOlan(deger1, deger2);

            //if(deger1 > deger2)
            //{
            //    Console.WriteLine("Büyük olan sayı :" + deger1);
            //}else if(deger1 < deger2)
            //{
            //    Console.WriteLine("Büyük olan sayı: " + deger2);
            //}
            //else
            //{
            //    Console.WriteLine("Sayılar eşittir.");
            //}
            Console.ReadLine();
        }

        // Parametresiz - Geriye değer döndürmeyen metot tanımlama.

        static void SelamVer()
        {
            // void = geriye değer döndürmeyendir. sadece çıktı verir.
            Console.WriteLine("Selamlar");
            Console.Read();
        }

        // Parametreli - Geriye değer döndürmeyen metot tanımlama.

        static void SelamAl(string selamlar)
        {
            Console.WriteLine("Aleykümselam");
            Console.Read();
        }

        static void Notlar(int sayi1,  int sayi2)
        {
            int ortalama = (sayi1 + sayi2) / 2;
            Console.WriteLine("Ortalamanız: " + ortalama);
            Console.ReadLine();
        }

        /* Parametre Alan - Geriye Değer Döndüren Metot Tanımlama
         * return anahtar kelimesi
         * metot sonu
         */

        static int ToplamaYap(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            return sonuc;
        }

        static string Isimler(string isim1, string isim2)
        {
            return isim1 + " " + isim2;
        }

        //girilen sayının karesini alma

        static int Karesi(int sayi)
        {
            return (sayi * sayi);
        }

        static int TekCift(int sayi)
        {
            return sayi;
        }

        static int BuyukOlan(int sayi1, int sayi2)
        {
            return sayi1;
            return sayi2;
        }

    }
}

