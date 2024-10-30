using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü

            //string[] cities = { "Ordu", "Samsun", "Trabzon", "Rize" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            ////------------------------------------------------------------

            //int[] numbers = { 15, 22, 120, 56, 98, 765, 957, 1098, 10986 };

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            ////-------------------------------------------------------------

            //int[] numbersss = { 15, 22, 120, 56, 98, 765, 957, 1098, 10986 };
            //int total = 0;

            //foreach (int i in numbersss)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);
            
            ////---------------------------------------------------------------

            //List<int> numberss = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numberss)
            //{
            //    Console.WriteLine(number);
            //}

            ////-----------------------------------------------------------------

            //string word = "Merhaba";

            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("-----------------------");

            //Console.WriteLine("**** C# Eğitim Kampı Sınav Uygulaması ****");
            //Console.WriteLine();

            ////Sınıftaki öğrenci sayısını kulllanıcıdan alma
            //Console.WriteLine("-----------------------");
            //Console.Write("Sınıfta Kaç Öğrenci Var = ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-----------------------");

            ////öğreni isimlerini ve not ortalamalrını saklayan diziler
            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i + 1}. öğrencinin ismini giriniz = ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenciiçin 3 sınav notu girişi

            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
            //        double value = double.Parse(Console.ReadLine());
            //        totalExamResult += value;
            //    }

            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine("-----------------------");
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalaması = {studentExamAvg[i]}");

            //    //öğrencilerin ortalaması ve geçip kalma durumları
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.");
            //    }
            //    Console.WriteLine("-----------------------");
            //}
            #endregion

            Console.Read();
        }
    }
}
