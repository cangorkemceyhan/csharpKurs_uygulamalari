using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpKurs_oop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci() { adSoyad = "Gorkem Ceyhan", bolum = "yazilim" };
            Ogrenci ogr2 = new Ogrenci() { adSoyad="Yigit Bilgi", bolum="bilgisayar"};
            Ogrenci ogr3 = new Ogrenci() { adSoyad="Ahmet Yilmaz",bolum="makine"};
            Ogrenci[] ogrenciler=new Ogrenci[3] { ogr1, ogr2,ogr3 };
            foreach(var o in ogrenciler)
            {
                Console.WriteLine(o.bilgileriYazdir());
            }

            Console.ReadKey();
        }
    }
    class Ogrenci
    {
        public string adSoyad { get; set; }
        public string bolum { get; set; }
        public string bilgileriYazdir()
        {
            return $"ogrencinin adi {this.adSoyad} ve bolumu {this.bolum}";
        }
    }
}
