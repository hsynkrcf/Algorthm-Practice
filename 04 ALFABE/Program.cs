using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_ALFABE
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            char[] yeniAlfabe = new char[27];
            string alfabe1 = string.Empty;
            char[] tamAlfabe = new char[26];
            int sira = 0, sayac = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                tamAlfabe[sira] = i;
                sira++;
            }
            for (int j = 0; j < sira;j++)
            {
                do
                {
                    yeniAlfabe[j] = Convert.ToChar(rnd.Next('a', '{'));
                    sayac++;
                } while (tamAlfabe[j] != yeniAlfabe[j]);
                alfabe1 += yeniAlfabe[j];
                Console.WriteLine("{0}-----{1}. Denemede Oluştu.", alfabe1, sayac);
            }


            Console.ReadKey();

        }
    }
}
