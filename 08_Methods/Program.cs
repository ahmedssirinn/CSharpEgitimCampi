using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metodlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Ahmed Said");
            //    Console.WriteLine("Ahmed Said");
            //    Console.WriteLine("Ahmed Said");
            //    Console.WriteLine("Ahmed Said");
            //}

            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = y + x;
            //    Console.WriteLine(z);
            //}

            //Sum();



            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metodlar

            //void WriteMethod(string customerName) 
            //{ 
            //    Console.WriteLine(customerName);    
            //}
            //WriteMethod("Ahmed Said");

            //--------------------------------------------

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Mehmet", "Yıldız");
            //CustomerCard("Ayşegül", "Kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metodlar

            //void Sum(int number1,  int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metodlar

            //string CustomerName()
            //{
            //    return "Buse Yıldız";
            //}

            //CustomerName();

            //-------------------------------------

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";

            //    return name + " " + surname;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metodlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ükle Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent Adını Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metodlar

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(1, 2));
            //Console.WriteLine(Sum(11, 22));
            //Console.WriteLine(Sum(41, 22));
            //Console.WriteLine(Sum(15, 92));


            #endregion

            Console.Read();
        }
    }
}
