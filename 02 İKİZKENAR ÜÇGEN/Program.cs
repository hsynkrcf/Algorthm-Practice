using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02_İKİZKENAR_ÜÇGEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int satır;
            Console.WriteLine("İKİZKENAR ÜÇGENİNİZ KAÇ SATIR OLSUN?");
            bool kontrol = int.TryParse(Console.ReadLine(), out satır);
            if (kontrol)
            {
                for (int i = 0; i < (satır+1); i++)
                {
                    for (int j = i; j < satır; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k<=i; k++)
                    {
                        Console.Write("*");
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("LÜTFEN SAYI GİRİNİZ!!");
            }
            Console.ReadKey();
        }
    }
}
