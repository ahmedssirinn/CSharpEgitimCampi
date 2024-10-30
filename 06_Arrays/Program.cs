using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = { "Ankara", "İstanbul", "Ordu", "Samsun", "Bursa" };

            //Console.WriteLine(cities[2]); 

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Mavi", "Yeşil", "Beyaz", "Siyah", "Gri" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 1, 22, 13, 24, 95, 76, 57, 861, 916, 2130, 1241 };

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', '*', '/' };

            //for (int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 12, 212, 653, 54, 15, 236, 74, 865, 569, 1012, 1341 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            //string[] persons = { "ali", "ahmed", "ayşe", "ela" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 2341, 223, 23, 49, 54, 676, 897, 58, 19, 103 };
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "buse", "çınar", "merve", "ela" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            ////-------------------------------------------------------------

            //int[] numbers = { 12, 22, 34, 54, 76, 23, 87 };
            //int toplam;
            //Console.WriteLine("En Büyük = " + numbers.Max() + " En Küçük = " + numbers.Min());
            //Console.WriteLine(toplam = numbers.Min() + numbers.Max());

            #endregion

            #region Kullanıcıdan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine();

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            ////--------------------------------------------------------

            //int[] numbers = { 10, 28, 37, 478, 515, 656, 1712, 1087, 9845 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("----------------");
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
