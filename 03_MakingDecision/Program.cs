using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi Giriniz: ");

            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.Write("Doğru Şifre!!");
            //} 
            //else
            //{
            //    Console.WriteLine("Yanlış Şifre");
            //}

            //string capital, country;

            //Console.Write("Başkent Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülke Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" && country == "türkiye")
            //{
            //    Console.Write("Veriler Doğru!");
            //}
            //else
            //{
            //    Console.Write("Veriler yanlış");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Hata!";

            //Console.Write("Sınav 1 = ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 2 = ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav 3 = ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine("Sınavların Ortalaması " + average);

            //if( average > 0 & average <= 50)
            //{
            //    result = "Sonuç Kötü";
            //}
            //if (average > 50 & average <= 100)
            //{
            //    result = "Sonuç İyi";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Şehir Girin: ");
            //city = Console.ReadLine();

            //if (city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut deeğiil");
            //}

            //Console.Write("Kullanıcı Adı: ");
            //string username = Console.ReadLine();

            //if (username == "admin")
            //{
            //    Console.WriteLine("Hoşgeldiniz!!");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış Kullanıcı adı");
            //}
            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;

            //int result = number % 5;
            //Console.WriteLine(result); //26nın 5e bölümünden kalan




            //Console.Write("1. Sayı : ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayı : ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. sayının 2. sayıya böölümünden kalan " + result);




            //Console.Write("Sayı Girin: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı Çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            #endregion

            #region Char Değişkenler Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım senbolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("**** Restoran Uygulaması ****");

            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- İçecekler");
            //Console.WriteLine("4- Tatlılar");

            //Console.Write("Detay Görmek İstediğiniz Menu: ");

            //string menuitem;
            //menuitem = Console.ReadLine();

            //if (menuitem == "1")
            //{
            //    Console.WriteLine("**** Ana Yemekler ****");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Tavuk Kızartması");
            //    Console.WriteLine("2- Pilav");
            //    Console.WriteLine("3- Sarma");
            //    Console.WriteLine("4- Dolma");
            //}

            //if (menuitem == "2")
            //{
            //    Console.WriteLine("**** Çorbalar ****");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Mercimek");
            //    Console.WriteLine("4- Ezogelin");
            //    Console.WriteLine("4- Tarhana");
            //    Console.WriteLine("4- Yayla");
            //}

            //if (menuitem == "3")
            //{
            //    Console.WriteLine("**** İçecekler ****");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Kola");
            //    Console.WriteLine("2- Fanta");
            //    Console.WriteLine("4- Soda");
            //    Console.WriteLine("4- Limonlu Gazoz");
            //}

            //if (menuitem == "4")
            //{
            //    Console.WriteLine("**** Tatlılar ****");
            //    Console.WriteLine();
            //    Console.WriteLine("1- Baklava");
            //    Console.WriteLine("2- Sütlaç");
            //    Console.WriteLine("4- Helva");
            //    Console.WriteLine("4- Dondurma");
            //}

            #endregion

            #region Switch Case

            //Console.WriteLine("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak");break;
            //    case 2:Console.WriteLine("Şubat");break;
            //    case 3:Console.WriteLine("Mart");break;
            //    case 4:Console.WriteLine("Nisan");break;
            //    case 5:Console.WriteLine("Mayıs");break;
            //    case 6:Console.WriteLine("Haziran");break;
            //    case 7:Console.WriteLine("Temmuz");break;
            //    case 8:Console.WriteLine("Ağustos");break;
            //    case 9:Console.WriteLine("Eylül");break;
            //    case 10:Console.WriteLine("Ekim");break;
            //    case 11:Console.WriteLine("Kasım");break;
            //    case 12:Console.WriteLine("Aralık");break;
            //    default: Console.WriteLine("Hatalı Giriş"); break;                   
            //}

            #endregion

            #region Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Gir: ");
            //number1 = int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Gir: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.Write("Yapmak İstediğiniz İşlem: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam = " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark = " + result);
            //        break;

            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Çarpım = " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm = " + result);
            //        break;

            //    default: Console.WriteLine("Hatalı Giriş");break;
            //}

            #endregion

            Console.Read();
        }
    }
}
