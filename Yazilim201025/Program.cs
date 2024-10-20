using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazilim201025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayi Girin");
            int sayi=Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("İkinci Sayi Girin");
            int sayi2 = Convert.ToInt16(Console.ReadLine());
            int toplam = sayi + sayi2;
            int carpma = sayi * sayi2;
            int cikarma = sayi - sayi2;
            int bolme = sayi / sayi2;
            Console.WriteLine($"Toplam {toplam} Çarpma {carpma} Bölme{bolme} Çıkarma {cikarma}");
            Console.ReadKey();

        }
    }
}
