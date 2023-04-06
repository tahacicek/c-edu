using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Musteri
    {
        public string musteriAdi;
        public string musteriSoyadi;
        public int musteriYasi;
        public int maasDegeri;
        private int Yas;

        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfı oluşturuldu.");
        }
        public void musteriBilgileriGoster()
        {
            Console.WriteLine("İsim: " + musteriAdi);
            Console.WriteLine("Soyisim: " + musteriSoyadi);
            Console.WriteLine("Yaş: " + Yas);
            Console.WriteLine("Maaş: " + maasDegeri);
        }

        private void musteriSoyadiGoster(string kisiSoyad)
        {
            Console.WriteLine("Müşterinin soyadı: " + kisiSoyad);
        }
    }
}
