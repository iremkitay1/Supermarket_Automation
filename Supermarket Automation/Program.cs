using System;
using System.Globalization;

namespace _2.video
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            Console.WriteLine("****************************  SHOPPING RECEIPT  ****************************");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("Please enter the apple kilogram");
            double appleGram = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the orange kilogram");
            double orangeGram = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the strawberry kilogram");
            double strawberryGram = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the potato kilogram");
            double potatoGram = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the tomato kilogram");
            double tomatoGram = double.Parse(Console.ReadLine());

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoPrice;
            double tomatoTotalPrice = tomatoGram * tomatoPrice;

            Console.WriteLine("---------------------------------- SHOPPING AMOUNT ----------------------------------");

            Console.WriteLine("   Apple      -> " + "    Price per kilogram: " + applePrice + "    - Total Price: " + appleTotalPrice);

            Console.WriteLine("   Orange     -> " + "    Price per kilogram: " + orangePrice + "    - Total Price: " + orangeTotalPrice);

            Console.WriteLine("   Strawberry -> " + "    Price per kilogram: " + strawberryPrice + "       - Total Price: " + strawberryTotalPrice);

            Console.WriteLine("   Potato     -> " + "    Price per kilogram: " + potatoPrice + "     - Total Price: " + potatoTotalPrice);

            Console.WriteLine("   Tomato     -> " + "    Price per kilogram: " + tomatoPrice + "     - Total Price: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;
            Console.WriteLine("+____________________________________________________________________________________");
            Console.WriteLine("   Total amount of shopping: " + shoppingTotalPrice);
            Console.WriteLine();

            #endregion

            Console.Read();
        }
    }
}