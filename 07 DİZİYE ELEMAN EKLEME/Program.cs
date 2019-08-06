using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int eleman;
            Console.Write("Kaç adet eleman gireceksiniz : ");
            bool kontrol  = int.TryParse(Console.ReadLine(), out eleman);
            if (kontrol)
            {
                object[] dizi = new object[eleman];
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write("{0}.Elemanı Giriniz : ",i+1);
                    dizi[i] = Console.ReadLine();
                }
                for (int i = 0; i < dizi.Length; i++)
                {
                    Console.Write ("{0}----",dizi[i]);
                    i++;
                    if (i!=dizi.Length)
                    {
                        Console.WriteLine("{0}", dizi[i]); 
                    }
                }
            }
            else
            {
                Console.WriteLine("LÜTFEN SAYI GİRİNİZ!!!");
            }

            Console.ReadKey();
        }
    }
}