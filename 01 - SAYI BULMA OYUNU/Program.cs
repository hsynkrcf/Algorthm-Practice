using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01___SAYI_BULMA_OYUNU
{
    class Program
    {
        static void Main(string[] args)
        {
            int rasgeleSayı = 0,tahmin,secim;                    //switch case ile seçtirdiğim zorluk seviyesi ile oyun başlıyor. makine bir sayı tutuyor 
            Console.WriteLine("OYUNA HOŞGELDİN..");              //tuttuğu sayıyı kullanıcının bulması için her defasında büyük,küçük diye söylüyor.
            Console.WriteLine("*****************************");  //eğer kullanıcı random sayıyı bulursa sayı gösterilip tebrik ediliyor ve program bitiyor.
            Console.WriteLine("ZORLUK SEVİYESİ SEÇİNİZ\n1.KOLAY 1-10\n2.ORTA 1-100\n3.ZOR 1-1000\nLÜTFEN BİR TANE ZORLUK SEÇİNİZ (1,2,3)");
            bool anaKontrol = int.TryParse(Console.ReadLine(), out secim);
            if (anaKontrol)
            {
                Random rnd = new Random();
                switch (secim)
                {
                    #region KOLAY İÇİN 
                    case 1:
                        Console.WriteLine("***********************************");
                        Console.WriteLine("ZORLUK SEVİYESİ KOLAY SEÇİLDİ!!!");
                        Console.WriteLine("1-10 ARASINDA BİR SAYI GİRİNİZ.");
                        bool kontrol = int.TryParse(Console.ReadLine(), out tahmin);
                        if (kontrol)
                        {
                            bool yanKontrol1 = false;
                            rasgeleSayı = rnd.Next(1, 10);
                            do
                            {
                                yanKontrol1 = int.TryParse(Console.ReadLine(), out tahmin);
                                if (yanKontrol1)
                                {
                                    if (tahmin < rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA BÜYÜK");
                                    }
                                    else if (tahmin > rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA KÜÇÜK");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("SADECE SAYI GİR");
                                }
                            } while (tahmin != rasgeleSayı);
                            Console.WriteLine("DOĞRU CEVAP {0} TEBRİKLER ", rasgeleSayı);
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN SAYI HARİCİ BİRŞEY GİRMEYİNİZ");
                        }
                        break;
                    #endregion
                    #region ORTA İÇİN
                    case 2:
                        Console.WriteLine("***********************************");
                        Console.WriteLine("ZORLUK SEVİYESİ ORTA SEÇİLDİ!!!");
                        Console.WriteLine("1-100 ARASINDA BİR SAYI GİRİNİZ.");
                        bool kontrol2 = int.TryParse(Console.ReadLine(), out tahmin);
                        if (kontrol2)
                        {
                            bool yanKontrol = false;
                            rasgeleSayı = rnd.Next(1, 100);
                            do
                            {
                                yanKontrol = int.TryParse(Console.ReadLine(), out tahmin);
                                if (yanKontrol)
                                {
                                    if (tahmin < rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA BÜYÜK");
                                    }
                                    else if (tahmin > rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA KÜÇÜK");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("SAYI GİRİNİZ!!");
                                }                              
                            } while (tahmin != rasgeleSayı);
                            Console.WriteLine("DOĞRU CEVAP {0} TEBRİKLER ", rasgeleSayı);
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN SAYI HARİCİ BİRŞEY GİRMEYİNİZ");
                        }
                        break;
                    #endregion
                    #region ZOR İÇİN
                    case 3:
                        Console.WriteLine("***********************************");
                        Console.WriteLine("ZORLUK SEVİYESİ ZOR SEÇİLDİ!!!");
                        Console.WriteLine("1-1000 ARASINDA BİR SAYI GİRİNİZ.");
                        bool kontrol3 = int.TryParse(Console.ReadLine(), out tahmin);
                        if (kontrol3)
                        {
                            bool yanKontrol2 = false;
                            rasgeleSayı = rnd.Next(1, 1000);
                            do
                            {
                                yanKontrol2 = int.TryParse(Console.ReadLine(), out tahmin);
                                if (yanKontrol2)
                                {
                                    if (tahmin < rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA BÜYÜK");
                                    }
                                    else if (tahmin > rasgeleSayı)
                                    {
                                        Console.WriteLine("DAHA KÜÇÜK");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("SADECE SAYI GİR");
                                }
                            } while (tahmin != rasgeleSayı);
                            Console.WriteLine("DOĞRU CEVAP {0} TEBRİKLER ", rasgeleSayı);
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN SAYI HARİCİ BİRŞEY GİRMEYİNİZ");
                        }
                        break;
                    #endregion
                    default:
                        Console.WriteLine("1,2 VEYA 3 TUŞU İLE SEÇİNİZ");
                        break;

                }
            }
            else
            {
                Console.WriteLine("LÜTFEN SAYI İLE GİRİNİZ!!!");
            }
            
            Console.ReadKey();
        }
    }
}
