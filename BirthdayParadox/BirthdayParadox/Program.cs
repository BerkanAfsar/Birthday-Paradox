using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BirthdayParadox
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[12][];
            gunleriOlustur(jaggedArray);
            tercih(jaggedArray);
        }

        public static int[][] gunleriOlustur(int[][] jaggedArray)
        {
            for (int i = 0; i < 12; i++)
            {
                jaggedArray[i] = new int[DateTime.DaysInMonth(2016, i + 1)];
            }
            return jaggedArray;
        }

        static void randomDogumGunuAtama(int[][] jaggedArray, Random random)
        {
            int[] n = { 100, 500, 1000 };          

            for (int k = 0; k < 3; k++)// n in farklı değerleri için
            {
                int[] cakismaSayisi = new int[10];
                double ortalama = 0;
                Console.WriteLine("{0} Kisi Icin", n[k]);

                for (int i = 0; i < 10; i++) // her bir n değerini 10 kere dondurcek
                {
                    gunleriOlustur(jaggedArray);

                    for (int j = 0; j < n[k]; j++)// n in değeri kadar dondurcek
                    {
                        int r = random.Next(0, 12);

                        if (jaggedArray[r][random.Next(0, jaggedArray[r].Length)] >= 1)
                        {
                            jaggedArray[r][random.Next(0, jaggedArray[r].Length)] += 1;
                        }
                        else
                        {
                            jaggedArray[r][random.Next(0, jaggedArray[r].Length)] = 1;
                        }
                    }
                    for (int a = 0; a < 12; a++)// cakışma var mı diye kontrol ediyoruz toplamda kac tane var ona bakiyoruz
                    {
                        for (int b = 0; b < jaggedArray[a].Length; b++)
                        {
                            if (jaggedArray[a][b] > 0)
                            {
                                cakismaSayisi[i] += (jaggedArray[a][b] - 1);// her bir n degerinde toplamda kaç çakışma olmuş onu gösterir
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine("{0}. Deney Icın Cakismanin Oldugu Aylar, Gunler Ve Sayilari: ", i + 1);

                    for (int d = 0; d < 12; d++)// cakışma var mı diye kontrol ediyoruz hangi gunler oldugunu yazdircaz
                    {
                        Console.Write("{0} . Ay Icin Cakismanin Oldugu Gunler :", d + 1);

                        for (int e = 0; e < jaggedArray[d].Length; e++)
                        {
                            if (jaggedArray[d][e] > 1)
                            {
                                Console.Write("  {0}:({1})  ", e + 1, jaggedArray[d][e]-1);
                            }
                        }
                        Console.WriteLine();
                    }
                }
                Console.ReadKey();
                Console.WriteLine();

                for (int c = 0; c < cakismaSayisi.Length; c++)
                {
                    Console.WriteLine("{0}. Deney Icın Toplam Cakisma Sayisi: {1}", c + 1, cakismaSayisi[c]);
                    ortalama += cakismaSayisi[c];
                }
                Console.WriteLine("Ortalama Cakisma Sayisi : {0}", ortalama / 10);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void ucAyRandomDogumGunuAtama(int[][] jaggedArray, Random random)
        {
            int[] n = { 100, 500, 1000 };

            for (int k = 0; k < 3; k++)// n in farklı değerleri için
            {
                int[] cakismaSayisi = new int[10];
                double ortalama = 0;
                Console.WriteLine("{0} Kisi Icin", n[k]);

                for (int i = 0; i < 10; i++) // her bir n değerini 10 kere dondurcek
                {
                    gunleriOlustur(jaggedArray);
                    // int m = 0; // cakışma var mı diye kullanılacak

                    for (int j = 0; j < n[k]; j++)// n in değeri kadar dondurcek
                    {
                        int r = random.Next(5, 8);

                        if (jaggedArray[r][random.Next(0, jaggedArray[r].Length)] >= 1)
                        {
                            jaggedArray[r][random.Next(0, jaggedArray[r].Length)] += 1;
                        }
                        else
                        {
                            jaggedArray[r][random.Next(0, jaggedArray[r].Length)] = 1;
                        }
                    }
                    for (int a = 0; a < 12; a++)// cakışma var mı diye kontrol ediyoruz toplamda kac tane var ona bakiyoruz
                    {
                        for (int b = 0; b < jaggedArray[a].Length; b++)
                        {
                            if (jaggedArray[a][b] > 0)
                            {
                                cakismaSayisi[i] += (jaggedArray[a][b] - 1);// her bir n degerinde toplamda kaç çakışma olmuş onu gösterir
                            }
                        }
                    }
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine("{0}. Deney Icın Cakismanin Oldugu Aylar, Gunler Ve Sayilari: ", i + 1);

                     for (int d = 5; d < 8; d++)// cakışma var mı diye kontrol ediyoruz hangi gunler oldugunu yazdircaz
                     {
                         Console.Write("{0} . Ay Icin Cakismanin Oldugu Gunler :", d + 1);

                         for (int e = 0; e < jaggedArray[d].Length; e++)
                         {
                             if (jaggedArray[d][e] > 1)
                             {
                                 Console.Write("{0}:({1})  ", e + 1, jaggedArray[d][e]-1);
                             }
                         }
                         Console.WriteLine();
                     }
                }
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("{0} Ogrenci Icin :", n[k]);

                for (int c = 0; c < cakismaSayisi.Length; c++)
                {
                    Console.WriteLine("{0}. Deney Icın Toplam Cakisma Sayisi: {1}", c + 1, cakismaSayisi[c]);
                    ortalama += cakismaSayisi[c];
                }

                Console.WriteLine("Ortalama Cakisma Sayisi : {0}", ortalama / 10);
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void tercih(int[][] jaggedArray)
        {
            int tercihNo;
            do
            {
                Console.WriteLine("12 Ayin Deney Sonuclarini Gormek Icin 1'e Basiniz.");
                Console.WriteLine("6-7 ve 8. Aylarin Deney Sonuclarini Görmek Icin 2'ye Basiniz.");
                Console.WriteLine("Kisi Sayisini Kendiniz Girmek Istiyorsaniz 3'e Basiniz.");
                Console.WriteLine("Cikmak Icin 4'e Basiniz.");
                tercihNo = Int32.Parse(Console.ReadLine());

                switch (tercihNo)
                {
                    case 1:
                        randomDogumGunuAtama(jaggedArray, random);
                        break;
                    case 2:
                        ucAyRandomDogumGunuAtama(jaggedArray, random);
                        break;
                    case 3:
                        girilenDegerKadarAtama(jaggedArray, random);
                        break;
                    case 4:
                        break;
                }
            } while (tercihNo != 4);
        }

        static void girilenDegerKadarAtama(int[][] jaggedArray, Random random)
        {
            int kisiSayisi;
            Console.Write("Kisi Sayisini Giriniz:");
            kisiSayisi = Int32.Parse(Console.ReadLine());

            int[] cakismaSayisi = new int[10];
            double ortalama = 0;

            for (int i = 0; i < 10; i++) // her bir n değerini 10 kere dondurcek
            {
                gunleriOlustur(jaggedArray);

                for (int j = 0; j < kisiSayisi; j++)// n in değeri kadar dondurcek
                {
                    int r = random.Next(0, 12);

                    if (jaggedArray[r][random.Next(0, jaggedArray[r].Length)] >= 1)
                    {
                        jaggedArray[r][random.Next(0, jaggedArray[r].Length)] += 1;
                    }
                    else
                    {
                        jaggedArray[r][random.Next(0, jaggedArray[r].Length)] = 1;
                    }
                }
                for (int a = 0; a < 12; a++)// cakışma var mı diye kontrol ediyoruz toplamda kac tane var ona bakiyoruz
                {
                    for (int b = 0; b < jaggedArray[a].Length; b++)
                    {
                        if (jaggedArray[a][b] > 0)
                        {
                            cakismaSayisi[i] += (jaggedArray[a][b] - 1);// her bir n degerinde toplamda kaç çakışma olmuş onu gösterir
                        }
                    }
                }
                Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine("{0}. Deney Icın Cakismanin Oldugu Aylar, Gunler Ve Sayilari: ", i + 1);

                for (int d = 0; d < 12; d++)// cakışma var mı diye kontrol ediyoruz hangi gunler oldugunu yazdircaz
                {
                    Console.Write("{0} . Ay Icin Cakismanin Oldugu Gunler :", d + 1);

                    for (int e = 0; e < jaggedArray[d].Length; e++)
                    {
                        if (jaggedArray[d][e] > 1)
                        {
                            Console.Write("{0}:({1})  ", e + 1, jaggedArray[d][e] - 1);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
            Console.WriteLine();

            for (int c = 0; c < cakismaSayisi.Length; c++)
            {
                Console.WriteLine("{0}. Deney Icın Toplam Cakisma Sayisi: {1}", c + 1, cakismaSayisi[c]);
                ortalama += cakismaSayisi[c];
            }
            Console.WriteLine("Ortalama Cakisma Sayisi : {0}", ortalama / 10);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

