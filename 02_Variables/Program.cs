using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region DoubleDeğişkenler
            //double number;
            //number = 4.58;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 10.55; orangePrice = 22.33; strawberryPrice = 65.85; potatoPrice = 15.56; tomatoPrice = 37.21;

            //Console.WriteLine("Elma Fiyatı = " + applePrice + " TL");
            //Console.WriteLine("Portakal Fiyatı = " + orangePrice + " TL");
            //Console.WriteLine("Çilek Fiyatı = " + strawberryPrice + " TL");
            //Console.WriteLine("Patates Fiyatı = " + potatoPrice+ " TL");
            //Console.WriteLine("Domates Fiyatı = " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.5; orangeGram = 2.3; strawberryGram= 0.5; potatoGram = 3.2; tomatoGram = 4.5;

            //double appleTotalPrice, orangeTotalPrice, strawberryTotalPrice, potatoTotalPrice, tomatoTotalPrice;

            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangePrice;
            //strawberryTotalPrice = strawberryGram * strawberryPrice;
            //potatoTotalPrice = potatoGram * potatoPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Elma Fiyatı = " + appleTotalPrice + " TL" );
            //Console.WriteLine("Alınan Portakal Fiyatı = " + orangeTotalPrice + " TL" );
            //Console.WriteLine("Alınan Çilek Fiyatı = " + strawberryTotalPrice + " TL" );
            //Console.WriteLine("Alınan Patates Fiyatı = " + potatoTotalPrice + " TL" );
            //Console.WriteLine("Alınan Domates Fiyatı = " + tomatoTotalPrice + " TL" );

            //Console.WriteLine();

            //double shoppingTotalPrice;

            //shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine("Toplam Tutar = " + shoppingTotalPrice + " TL");

            #endregion

            #region CharDeğişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String

            //Console.WriteLine("**** C# Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passangerName, passangerSurname, passangerDistrict, passangerCity, passangerAge, passangerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passangerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passangerSurname = Console.ReadLine();

            //Console.Write("İlçe: ");
            //passangerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passangerCity = Console.ReadLine();

            //Console.Write("Yaş: "); 
            //passangerAge = Console.ReadLine();

            //Console.Write("TC Kimlik: ");
            //passangerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------");
            //Console.WriteLine("Yolcu: " + passangerName + " " + passangerSurname + " Kimlik No: " + passangerIdentityNumber + " Yaş: " + passangerAge + " Şehir: " + passangerCity+ "/" + passangerDistrict);

            //Console.WriteLine();    


            #endregion

            #region Klavyeden TamSayı Girişleri ve Dönüşümler

            //int computerPrice, tvPrice, chairPrice, tablePrice;

            //computerPrice = 25000; tvPrice = 20000; chairPrice = 3000; tablePrice = 8000;

            //Console.WriteLine("**** Eşya Fiyatları ****");
            //Console.WriteLine();
            //Console.WriteLine("Bilgisayar = " + computerPrice);
            //Console.WriteLine("Televizyon = " + tvPrice);
            //Console.WriteLine("Sandalye = " + chairPrice);
            //Console.WriteLine("Masa = " + tablePrice);

            //Console.WriteLine();

            //int computerCount, tvCount, chairCount, tableCount;

            //Console.Write("Alacağınız Pc Sayısı = ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Alacağınız Tv Sayısı = ");
            //tvCount = int.Parse(Console.ReadLine());

            //Console.Write("Alacağınız Sandalye = ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Alacığınız Masa Sayısı = ");
            //tableCount = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("**** Hesap Tutarı ****");
            //Console.WriteLine();

            //int computerTotal, tvTotal, chairTotal, tableTotal, TotalPrice;

            //computerTotal = computerPrice * computerCount;
            //tvTotal = tvPrice * tvCount;
            //chairTotal = chairPrice * chairCount;
            //tableTotal = tablePrice * tableCount;

            //TotalPrice = computerTotal + tableTotal + chairTotal + tableTotal;

            //Console.Write("Toplam Fiyat = " + TotalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.WriteLine("1. Sınav Notu = ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("2. Sınav Notu = ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("3. Sınav Notu = ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Karakter Girişleri

            //char gender;

            //Console.Write("Cinsiyet Seç: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
} 
