using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_ŞİFRE_ÜRETİCİ
{
    class Program
    {
        static void Main(string[] args)
        {
            basla:
            Random rastgele = new Random();
            Console.WriteLine("YENİ ŞİFRENİZ ÜRETİLDİ");
                for (int i = 1; i <= 3; i++)
                {
                    int sayi1 = rastgele.Next(65, 91);
                    Console.Write((char)sayi1);
                }
                 for (int i = 1; i <= 2; i++)
                {
                int sayi1 = rastgele.Next(48, 58);
                Console.Write((char)sayi1);
                }
                for (int i = 1; i <= 3; i++)
                {
                    int sayi1 = rastgele.Next(97, 123);
                    Console.Write((char)sayi1);
                }
                
            Console.ReadKey();
            goto basla;

        }
    }
}
