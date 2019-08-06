using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05_METİN_İÇİ_SAYI
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin = string.Empty;
            int sayac = 0;
            Console.WriteLine("METİN GİRİNİZ: ");
            metin = Console.ReadLine();

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] >= '0' && metin[i] <= '9')
                {
                    sayac++;
                }
            }
            Console.WriteLine(sayac);
            Console.ReadKey();
        }
    }
}
