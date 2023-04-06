using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaMarkasi;
        public string arabaRengi;

        public Araba(int _kapiSayisi, string _arabaMarkasi, string _arabaRengi)
        {
            kapiSayisi = _kapiSayisi;
            arabaMarkasi = _arabaMarkasi;
            arabaRengi = _arabaRengi;
        }
        public void Calistir()
        {
            Console.WriteLine("Araba çalıştı.");
        }

        public void Dur()
        {
            Console.WriteLine("Araba durdu.");
        }

        public void KapilariKapat()
        {
            Console.WriteLine("Arabanın kapıları kapatıldı.");
        }

    }
}
