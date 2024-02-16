using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace csharpKursuUygulamalari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            var sonuc = karakterDuzeltme.karakterDuzelt("can görkem ceyhan");
            Console.WriteLine(sonuc);
            */



            /*
            Console.Write("Parola: ");
            string parola=Console.ReadLine();
            try
            {
                parola_kontrol(parola);
                Console.WriteLine("Parola gecerli");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            */

            

            Console.ReadKey();

        }
        private static void stringOrnek()
        {
            string message = "Gorkem 23 yaşındadır.";
            var sonuc0 = message.Length;
            var sonuc1 = message.ToLower();
            var sonuc2 = message.ToUpper();
            var sonuc3 = message.Trim();
            var sonuc4 = message.Split()[0];
            var sonuc5 = message[0];
            var sonuc6 = message.StartsWith("C");
            var sonuc7 = message.EndsWith(".");
            var sonuc8 = message.Contains("Gorkem");
            var sonuc9 = message.IndexOf("abc");
            var sonuc10 = message.Substring(6, 5);
            Console.WriteLine(sonuc0);
            Console.WriteLine(sonuc1);
            Console.WriteLine(sonuc2);
            Console.WriteLine(sonuc3);
            Console.WriteLine(sonuc4);
            Console.WriteLine(sonuc5);
            Console.WriteLine(sonuc6);
            Console.WriteLine(sonuc7);
            Console.WriteLine(sonuc8);
            Console.WriteLine(sonuc9);
            Console.WriteLine(sonuc10);
        }
        private static void stringMetotlari()
        {
            string metin = "Can Görkem Ceyhan İstanbulda yaşıyor";
            var karakterSayisi = metin.Length;
            Console.WriteLine(karakterSayisi);
            var kucukHarf = metin.ToLower();
            Console.WriteLine(kucukHarf);
            var konum = metin.IndexOf("Can");
            Console.WriteLine("konum: " + konum);
            var iceriyorMu = metin.Contains("Gorkem");
            Console.WriteLine("metin iceriyor mu: " + iceriyorMu);
            var guncel = metin.Replace("yaşıyor", "yaşamakta");
            Console.WriteLine(guncel);
        }
        private static void zamanMetotlari()
        {
            var simdi=DateTime.Now;
            Console.WriteLine(simdi);
            Console.WriteLine(simdi.Year);
            Console.WriteLine(simdi.Month);
            Console.WriteLine(simdi.Day);
            Console.WriteLine(simdi.DayOfWeek);
            Console.WriteLine(simdi.Hour);
            Console.WriteLine(simdi.Minute);
            Console.WriteLine(simdi.Second);
            DateTime dt = new DateTime(2018, 6, 10, 14, 30, 45);
            dt.AddYears(1);
            Console.WriteLine(dt.Year);
        }
        private static void diziMetotlari()
        {
            string[] sehirler = { "İstanbul", "Bursa", "Diyarbakir" };
            int[] plakalar = { 34, 16, 21 };
            Console.WriteLine(sehirler.GetValue(1));
            Console.WriteLine(sehirler.Length);
            Console.WriteLine(Array.IndexOf(sehirler, "Diyarbakir"));
            Array.Sort(sehirler);
            Array.Sort(plakalar);
            Array.Reverse(plakalar);
            Console.WriteLine(plakalar.GetValue(0));
            Console.WriteLine(plakalar.GetValue(1));
            Console.WriteLine(plakalar.GetValue(2));
            foreach(var sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
        }
        private static void operatorler()
        {
            var ogrenciler = new string[3];
            var notlar = new int[3];
            Console.Write("1. ogrenci adi: ");
            ogrenciler[0] = Console.ReadLine()?? "";
            Console.Write("1. ogrenci notu: ");
            notlar[0]=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ogrenci adi: ");
            ogrenciler[1] = Console.ReadLine() ?? "";
            Console.Write("2. ogrenci notu: ");
            notlar[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. ogrenci adi: ");
            ogrenciler[2] = Console.ReadLine() ?? "";
            Console.Write("3. ogrenci notu: ");
            notlar[2] = Convert.ToInt32(Console.ReadLine());
            foreach(var ogrenci in ogrenciler)
            {
                Console.WriteLine(ogrenci);
            }
            foreach(var ogrenciNotu in notlar)
            {
                Console.WriteLine(ogrenciNotu);
            }
            Console.WriteLine("Ogrenciler dizisinin eleman sayisi: "+ogrenciler.Length);
            var not1 = notlar[0];
            var not2 = notlar[1];
            var not3 = notlar[2];
            var ort=(not1+not2+not3)/3;
            Console.WriteLine("Ogrencilerin not ortalamasi: " + ort);
        }
        private static void diziOrnek()
        {
            string[] ogrenciler = { "Can", "Gorkem", "İlyas" };
            int[,] notlar = new int[3, 3];
            notlar[0, 0] = 50;
            notlar[0, 1] = 60;
            notlar[0, 2] = 70;
            notlar[1, 0] = 60;
            notlar[1, 1] = 80;
            notlar[1, 2] = 90;
            notlar[2, 0] = 50;
            notlar[2, 1] = 70;
            notlar[2, 2] = 30;
            var ort1 = (notlar[0,0] + notlar[0, 1] + notlar[0,2])/3;
            var ort2 = (notlar[1, 0] + notlar[1, 1] + notlar[1, 2]) / 3;
            var ort3 = (notlar[2, 0] + notlar[2, 1] + notlar[2, 2]) / 3;
            Console.WriteLine($"{ogrenciler[0]} isimli ogrencinin not ortalaması: {ort1}");
            Console.WriteLine($"{ogrenciler[1]} isimli ogrencinin not ortalaması: {ort2}");
            Console.WriteLine($"{ogrenciler[2]} isimli ogrencinin not ortalaması: {ort3}");
        }
        private static void tekCift()
        {
            Console.Write("Bir sayi giriniz: ");
            var sayi=Convert.ToInt32(Console.ReadLine());
            var sonuc= (sayi%2==1)?"Sayi tek":"Sayi cift";
            Console.WriteLine(sonuc);
        }
        private static void randomMethot()
        {
            string[] takimlar = { "Beşiktaş", "Fenerbahçe", "Galatasaray" };
            var rand=new Random();
            int sayi=rand.Next(0,2);
            Console.WriteLine(sayi);
            Console.WriteLine(takimlar[sayi]);
        }
        private static void ifElse()
        {
            Console.WriteLine("Toplama işlemi için: +");
            Console.WriteLine("Çıkarma işlemi için: -");
            Console.WriteLine("Çarpma işlemi için: *");
            Console.WriteLine("Bölme işlemi için: /");
            string bosluk = new string('-', 26);
            Console.WriteLine(bosluk);
            Console.Write("Seçiminizi giriniz: ");
            var secim=Console.ReadLine();
            Console.Write("1. sayi: ");
            var sayi1=Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayi: ");
            var sayi2=Convert.ToInt32(Console.ReadLine());
            double sonuc = 0;
            if (secim == "+")
                sonuc = sayi1 + sayi2;
            else if (secim == "-")
                sonuc = sayi1 - sayi2;
            else if (secim == "*")
                sonuc = sayi1 * sayi2;
            else if (secim == "/")
                sonuc = sayi1 / sayi2;
            else
                Console.WriteLine("Yanlış seçim!");
            Console.WriteLine($"İşlem sonucu: {sonuc}");
        }
        private static void switchOrnek()
        {
            int gun=(int)DateTime.Now.DayOfWeek;
            switch(gun)
            {
                case 0: Console.WriteLine("Pazar");
                    break;
                case 1: Console.WriteLine("Pazartesi");
                    break;
                case 2:
                    Console.WriteLine("Salı");
                    break;
                case 3:
                    Console.WriteLine("Çarşamba");
                    break;
                case 4:
                    Console.WriteLine("Perşembe");
                    break;
                case 5:
                    Console.WriteLine("Cuma");
                    break;
                case 6:
                    Console.WriteLine("Cumartesi");
                    break;
                default: Console.WriteLine("Hatali gun!");
                    break;
            }
        }
        private static void ternaryOrnek()
        {
            Console.Write("Bir sayi giriniz: ");
            int sayi=Convert.ToInt32(Console.ReadLine());
            var sonuc = (sayi % 2 == 0) ? (sayi > 0) ? "Pozitif ve cift sayi" : "Negatif ve cift sayi" :
                (sayi > 0) ? "Pozitif ve tek sayi" : "Negatif ve tek sayi";
            Console.WriteLine(sonuc);
        }
        private static void forDongu()
        {
            Console.Write("Baslangic: ");
            var baslangic=Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitis: ");
            var bitis=Convert.ToInt32(Console.ReadLine());
            var toplam = 0;
            for(var i=baslangic;i<bitis; i++)
            {
                toplam += i;
            }
            Console.WriteLine(toplam);
        }
        private static void diziDongu()
        {
            string[] isimler = { "Ali", "Ahmet", "Can", "Gorkem", "Busra" };
            for(var i=0;i<isimler.Length;i++)
            {
                Console.WriteLine(isimler[i]);
            }
        }
        private static void ucKati()
        {
            int[] sayilar = { 1, 3, 5, 7, 9 };
            for(var i=0;i<sayilar.Length;i++)
            {
                if (sayilar[i]%3==0)
                {
                    Console.WriteLine(sayilar[i]);
                }
            }
        }
        private static void whileOyun()
        {
            var rnd=new Random();
            int tutulan = rnd.Next(1, 100);
            int hak = 3;
            while (hak > 0)
            {
                Console.WriteLine(tutulan);
                Console.Write("Sayi: ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                hak--;
                if(sayi==tutulan)
                {
                    Console.WriteLine("Tebrikler bildiniz!");
                    break;
                }
                else
                {
                    if (hak == 0)
                    {
                        Console.WriteLine("Oyun bitti");
                        break;
                    }
                    if (tutulan > sayi)
                    {
                        Console.WriteLine("Yukari");
                    }
                    else
                    {
                        Console.WriteLine("Asagi");
                    }
                }
            }

        }
        private static void dosyaİslem()
        {
            string sonuc = File.ReadAllText("C:\\Users\\hp\\source\\" +
                "repos\\csharpKursuUygulamalari\\csharpKursuUygulamalari\\deneme.txt");
            Console.WriteLine(sonuc);
            using (StreamWriter sw = File.CreateText("C:\\Users\\hp\\source\\" +
                "repos\\csharpKursuUygulamalari\\csharpKursuUygulamalari\\deneme.txt"))
            {
                sw.WriteLine("Merhaba!");
            }
            using(StreamWriter sw=File.AppendText("C:\\Users\\hp\\source\\" +
                "repos\\csharpKursuUygulamalari\\csharpKursuUygulamalari\\deneme.txt"))
            {
                sw.WriteLine("Selam!");
            }
            using(StreamReader sr=File.OpenText("C:\\Users\\hp\\source\\" +
                "repos\\csharpKursuUygulamalari\\csharpKursuUygulamalari\\deneme.txt"))
            {
                var s = "";
                while((s = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(s);
                }
            }

        }
        private static void koleksiyonlarOrnek()
        {
            /*
            List<int> sayilar= new List<int>();
            sayilar.Add(10);
            sayilar.Add(20);
            List<string> isimler = new List<string>() { "Ali", "Ahmet", "Ayşe" };
            */
            List<Product> urunler = new List<Product>();
            urunler.Add(new Product() { Id = 1, Title = "IPhone 14", Price = "4000" });
            urunler.Add(new Product() { Id = 2, Title = "IPhone 15", Price = "5000" });
            urunler.Add(new Product() { Id = 3, Title = "IPhone 16", Price = "6000" });
            foreach(var urun in urunler)
            {
                Console.WriteLine(urun.Title + " " + urun.Price);
            }
        }
        private static void hataKontrol()
        {
            try
            {
                Console.Write("1.sayi:");
                int sayi1=Convert.ToInt32(Console.ReadLine());
                Console.Write("2.sayi: ");
                int sayi2=Convert.ToInt32(Console.ReadLine());
                var sonuc = sayi1 / sayi2;
                Console.WriteLine(sonuc);
            }
            catch(FormatException)
            {
                Console.WriteLine("Sayi bilgileri yanlis!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sayi 0 olmamali!");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Bir hata oluştu!");
                Console.WriteLine(ex.Message);
            }
        }
        static void parola_kontrol(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                throw new Exception("Parola 6-10 karakter olmali!");
            }
            if(password.Any(char.IsDigit))
            {
                Console.WriteLine("Parola en az 1 rakam icermeli!");
            }
            if(!password.Any(char.IsLetter))
            {
                Console.WriteLine("Parola en az 1 harf icermeli!");
            }
        }
        class Product
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Price { get; set; }
        }
    }
    class karakterDuzeltme
    {
        public static string karakterDuzelt(string s)
        {
            return s.Replace("ö", "o").Replace("ü", "u").Replace("ı", "i").Replace(" ", "-");
        }
    }
}
