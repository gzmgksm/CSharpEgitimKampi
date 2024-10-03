using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Merhaba Dünya");//değeri yazdırır sonra imleci alt satıra indirir
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri *****");

            #endregion

            #region string_Değişkenler

            //string (alfabetik değişkenler)
            //Degişken_türü değişken_adı;

            //string name;
            //name = "Gizem";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Ali";
            //customerSurname = "Çınar";
            //customerPhone = "+90 507 008 06 08 ";
            //customerEmail = "ali.cinar@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";


            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("email adresi" + customerEmail);
            //Console.WriteLine("Adres" + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");

            //Console.WriteLine();

            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 16";
            //customerEmail = "aysegül.kaya@gmail.com";
            //district = "Merkez";
            //city = "Çorum";

            //Console.WriteLine("-----------------------------------------");
            //Console.WriteLine("müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("iletişim" + customerPhone);
            //Console.WriteLine("email adresi" + customerEmail);
            //Console.WriteLine("Adres" + district + "/" + city);
            //Console.WriteLine("-----------------------------------------");









            #endregion

            #region int Değişkenler

            //int (tamsayı türündeki değişkenler
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonedePrice = 30;
            Console.WriteLine("**** Restorant Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----Hamburger Fiyatı:" + hamburgerPrice + "Tl");
            Console.WriteLine("----Pizza Fiyatı:" + pizzaPrice + "Tl");
            Console.WriteLine("----Limonata Fiyatı:" + lemonedePrice + "Tl");
            Console.WriteLine("----Kızartma Fiyatı:" + friesPrice + "Tl");
            Console.WriteLine("----Su Fiyatı:" + waterPrice + "Tl");
            Console.WriteLine("----Kola Fiyatı:" + cokePrice + "Tl");
            Console.WriteLine();
            Console.WriteLine("**** Restorant Menü Fiyatı ****");


            Console.WriteLine();
            int hamburgerCount;
            int pizzaCount;
            int waterCount;
            int friesCount;
            int cokeCount;
            int lemonedeCount;

            int totalHamburgerPrice = 0;
            int totalWaterPrice = 0;
            int totalCokePrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonedePrice = 0;
            int totalFriesPrice = 0;



            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonedeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonedePrice = lemonedeCount * lemonedePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            Console.WriteLine("---------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice + "Tl");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + "Tl");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + "Tl");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + "Tl");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + "Tl");
            Console.WriteLine("Limonata Tutarı: " + totalLemonedePrice + "Tl");
            Console.WriteLine();

            int totalPrice = totalFriesPrice + totalWaterPrice + totalLemonedePrice + totalPizzaPrice + totalCokePrice + totalHamburgerPrice;
            Console.WriteLine("Toplam Ödenecek Tutar:" + totalPrice + "Tl");







            #endregion 
            Console.Read();


        }
    }
}    




//Yazdırma komutları



