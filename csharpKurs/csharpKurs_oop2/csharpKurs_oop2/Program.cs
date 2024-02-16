using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpKurs_oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soru1 = new Soru() { soruMetni = "3+1=?", 
                secenekler = new string[4] { "4", "5", "6", "7" }, cevap = "4" };
            var soru2 = new Soru()
            {
                soruMetni = "15+7=?",
                secenekler = new string[4] { "33", "32", "27", "22" },
                cevap = "22"
            };
            var soru3 = new Soru()
            {
                soruMetni = "54+16=?",
                secenekler = new string[4] { "83", "73", "70", "71" },
                cevap = "70"
            };
            var sorular=new Soru[] {soru1,soru2,soru3};
            foreach(var soru in sorular)
            {
                Console.WriteLine(soru.soruMetni);
                foreach(var secenek in soru.secenekler)
                {
                    Console.WriteLine(secenek);
                }
                Console.Write("Cevabinizi giriniz: ");
                var cevap=Console.ReadLine();
                if (soru.cevapKontrol(cevap))
                {
                    Console.WriteLine("Doğru cevap!");
                }
                else
                {
                    Console.WriteLine("Yanlis cevap!");
                }
            }

            Console.ReadKey();
        }
        class Soru
        {
            public string soruMetni { get; set; }
            public string[] secenekler { get; set; }
            public string cevap { get; set; }
            public bool cevapKontrol(string cevap)
            {
                return this.cevap.ToLower()==cevap.ToLower();
            }
        }
    }
}
