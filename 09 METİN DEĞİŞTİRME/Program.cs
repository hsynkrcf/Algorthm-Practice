using System;

namespace _05_ArrayExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Metni Girin : ");
                string metin = Console.ReadLine();
                string metin2 = string.Empty;
                Console.Write("Hangi Harfi Değiştireceksiniz ? :");
                char degisicekHarf = Convert.ToChar(Console.ReadLine());
                Console.Write("Yerine Hangi Harfi Koymak İstiyorsunuz ? :");
                char yerineHarf = Convert.ToChar(Console.ReadLine());
                for (int i = 0; i < metin.Length; i++)
                {
                    if (metin[i]==degisicekHarf)
                    {
                        metin2 += yerineHarf;
                    }
                    else
                    {
                        metin2 += metin[i];
                    }
                }
                Console.WriteLine(metin2);
            }
            Console.ReadKey();
        }
    }
}
