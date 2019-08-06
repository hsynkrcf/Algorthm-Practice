using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_BÜYÜK_HARF_KÜÇÜK_HARF
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin1 = string.Empty;
            string metin2 = string.Empty;

            Console.WriteLine("METİN GİRİNİZ: ");
            metin1 = Console.ReadLine();
            int harf = 0;
            for (int i = 0; i < metin1.Length; i++)
            {
                harf = Convert.ToChar(metin1[i]);
                if (harf >= 64 && harf <= 91)
                {
                    metin2 += Convert.ToChar(harf+32);
                }
                else if (harf >= 96 && harf <= 123)
                {
                    metin2 += Convert.ToChar(harf - 32);
                }
            }
            Console.WriteLine(metin2);
            Console.ReadKey();
        }
    }
}
