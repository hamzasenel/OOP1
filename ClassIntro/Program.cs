using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs() { egitmen="hamzasenel11111111111",kursAdi="turkce",izlenmeOrani=68};
            Kurs kurs2 = new Kurs() { egitmen = "hamzasenel2222", kursAdi = "matematik", izlenmeOrani = 98 };
            Kurs kurs3 = new Kurs() { egitmen = "hamzasenel3333", kursAdi = "english", izlenmeOrani = 78 };
            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3};
            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.egitmen+item.izlenmeOrani+item.kursAdi);
            }
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}
