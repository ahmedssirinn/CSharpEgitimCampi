﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            //For(x;y;z)
            //x: başlangıç
            //y: bitiş
            //z: artış-azalış

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Seviyorum");
            //}

            //for (int i = 0; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Kaç tane yazdırmak istiyorsunuz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i < finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet!");
            //}

            #endregion

            #region For Faköriyel 

            //Console.WriteLine("**** FAKTÖRİYEL ****");
            //Console.WriteLine();

            //int fact = 1, number;
            //Console.Write("Sayı = ");
            //number = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= number; i++)
            //{
            //    fact *= i;
            //}

            //Console.WriteLine(number + "! = " + fact);

            //Console.Read();

            #endregion

            #region For Döngüsü Karar Yapıları

            //for (int i = 1; i<=100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    } 
            //}

            //int totalvalue = 0;

            //for (int i = 0; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);

            //int totalvalue = 0;

            //for (int i = 0; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(totalvalue);

            //int count = 0;

            //for (int i = 1; i<=50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 1; i <=24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine(i + ". Saat Sonunda " + bacterium);
            //}

            #endregion

            #region While Döngüsü

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 1;
            //while (i <= 10)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}

            //int i = 1, sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);



            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız

            //Console.Write("Sayı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100) / 10;  
            //hundreds = number / 100;

            //Console.WriteLine(ones + "-" + tens + "-" + hundreds);

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu 2 (double method)

            //double ortalama = 0;

            //Hesapla(ortalama);

            #endregion

            Console.Read();
        }
            #region Örnek Sınav Sorusu 2 devamı

        //public static void Hesapla(double ortalama)
        //{
        //    double vizenotu, finalnotu, butnotu, butortalama;

        //    try
        //    {
        //        while (true)
        //        {
        //            Console.Write("Vize Notu = ");
        //            vizenotu = double.Parse(Console.ReadLine());

        //            if (vizenotu > 100)
        //            {
        //                Console.WriteLine("Sınav notu 100'den büyük olamaz");
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }

        //        while (true)
        //        {
        //            Console.Write("Final Notu = ");
        //            finalnotu = double.Parse(Console.ReadLine());

        //            if (finalnotu > 100)
        //            {
        //                Console.WriteLine("Sınav notu 100'den Büyük olamaz");

        //            }
        //            else if (finalnotu < 35)
        //            {
        //                Console.WriteLine("KALDINIZ! - Herhangi bir dersten geçmeniz için Final sınavından FF almamalısınız!!");
        //                goto ButSinavi;
        //            }
        //            else
        //            {
        //                break;
        //            }
        //        }

        //        ortalama = (vizenotu * 0.4) + (finalnotu * 0.6);

        //        if (ortalama >= 50)
        //        {
        //            Console.WriteLine("Ortalamanız = " + ortalama + " G");
        //        }

        //        else
        //        {
        //            Console.WriteLine("Ortalamanız = " + ortalama + " K");
        //            Console.WriteLine();
        //        }

        //    ButSinavi:;

        //        Console.WriteLine("Bütünleme Sınavı!!!");
        //        Console.WriteLine();

        //        if (ortalama < 50)
        //        {
        //            while (true)
        //            {

        //                Console.Write("Büt Notu = ");
        //                butnotu = double.Parse(Console.ReadLine());

        //                if (butnotu > 100)
        //                {
        //                    Console.WriteLine("Sınav notu 100'den büyük olamaz!");
        //                }
        //                else
        //                {
        //                    break;
        //                }
        //            }

        //            butortalama = (vizenotu * 0.4) + (butnotu * 0.6);

        //            if (butortalama >= 50)
        //            {
        //                Console.WriteLine("Yeni Ortalamanız = " + butortalama + " G");
        //            }
        //            else
        //            {
        //                Console.WriteLine("Yeni Ortalamanız = " + butortalama + " K");
        //            }
        //        }

        //    }

        //    catch (Exception hata)
        //    {
        //        Console.WriteLine("Hata meydana geldi!! \n" + hata);
        //    }

        //    finally
        //    {
        //        Console.Read();
        //    }
        //}
        
        #endregion

    }
}
