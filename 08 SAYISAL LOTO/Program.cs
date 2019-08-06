using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace _08_SAYISAL_LOTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MERHABA, HÜSEYİN LOTO'YA HOŞGELDİN :)");
            Console.WriteLine("***************************************");
            Console.WriteLine("4 KOLON OYNAMAK ZORUNLUDUR!!!");
            Console.WriteLine("LÜTFEN SADECE SAYI GİRİNİZ!!\nBAŞKA BİRŞEY GİRİLMESİ HALİNDE YENİDEN BAŞLARSINIZ!!");
            Console.WriteLine("***************************************");
            Random rnd = new Random();

            int[] sansliSayılar = new int[6];
            int[] tahmin = new int[6];
            int tuttu = 0;
            int[] kacıncıKolon = new int[4];
            bool kontrol = false,kontrol2=false,kontrol3=false;

            #region SanslıRakamÜretme
            for (int i = 0; i < 6; i++)
            {
                sansliSayılar[i] = rnd.Next(1, 50);
                for (int j = 0; j < i; j++)
                {
                    if (sansliSayılar[j] == sansliSayılar[i])
                    {
                        j = 10;
                        kontrol2 = true;
                    }
                }
                if (kontrol2)
                {
                    i--;
                    kontrol2 = false;
                }
            }
            #endregion

            #region Rakamları Alma Karşılaştırma
            
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                tuttu = 0;
                Console.WriteLine("{0}.KOLON", j + 1);
                for (int i = 0; i < 6; i++)
                {
                    Console.Write("{0}.SAYIYI GİRİNİZ(1,49) :", i +1);
                    kontrol = int.TryParse(Console.ReadLine(), out tahmin[i]);
                    if (kontrol && 1<=tahmin[i] && tahmin[i]<=49)
                    {
                        for (int u= 0; u < i; u++)
                        {
                            if (tahmin[u] == tahmin[i])
                            {
                                u = 10;
                                kontrol3 = true;
                                Console.WriteLine("BU SAYI DAHA ÖNCE OYNANMIŞ = {0}\nYENİ SAYI GİRİNİZ!!",tahmin[i]);
                            }
                        }
                        if (kontrol3)
                        {
                            i--;
                            kontrol3 = false;
                        }
                        for (int l = 0; l < 6; l++)
                            {
                                if (tahmin[i] == sansliSayılar[l])
                                {
                                    tuttu++;
                                    kacıncıKolon[j] = tuttu;
                                }
                            }
                    }
                else
                    {
                        Console.WriteLine("LÜTFEN 1-49 ARASI SADECE SAYI GİRİNİZ!!");
                        i = 10; j = 10;
                    }
                }
                Console.WriteLine("********************************");
            }
            #endregion

            #region PROGRAM SONU 
            Console.Write("BU HAFTANIN ŞANSLI SAYILARI : ");
            for (int i = 0; i < 6; i++)
            {
                Console.Write(sansliSayılar[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}.Kolonda {1} Sayı Tutturdunuz...", i + 1, kacıncıKolon[i]);
                if (kacıncıKolon[i] == 6)
                {
                    Console.WriteLine("********** TEBRİKLER **********");
                    Console.WriteLine("BÜYÜK İKRAMIYEYİ KAZANDINIZZ!!");
                }
            } 
            #endregion

            Console.ReadKey();
        }
    }
}
