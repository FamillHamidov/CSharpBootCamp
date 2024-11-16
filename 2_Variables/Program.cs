using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double

            Console.WriteLine("*****  Qiymet siyahısı  *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("---- Apple price:" + applePrice + " AZN");
            Console.WriteLine("---- Orange price:" + orangePrice + " AZN");
            Console.WriteLine("---- Strawberry price" + strawberryPrice + " AZN");
            Console.WriteLine("---- Potato price" + potatoPrice + " AZN");
            Console.WriteLine("---- Tomato price" + tomatoPrice + " AZN");

            Console.WriteLine();
            Console.WriteLine();

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.2;
            orangeGram = 2.3;
            strawberryGram = 3.4;
            potatoGram = 2.6;
            tomatoGram = 4.5;

            double appleTotalPrice = applePrice * appleGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double potatoTotalPrice = potatoPrice * potatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine("Apple - " + "Price: " + applePrice + " - Gram: " + appleGram + " - Total Price: " + appleTotalPrice + " AZN"); ;
            Console.WriteLine("Orange - " + "Price: " + orangePrice+ " - Gram: " + orangeGram+ " - Total Price: " + orangeTotalPrice + " AZN") ;
            Console.WriteLine("Strawberry - " + "Price: " + strawberryPrice + " - Gram: " + strawberryGram + " - Total Price: " + strawberryTotalPrice + " AZN"); ;
            Console.WriteLine("Potato - " + "Price: " + potatoPrice + " - Gram: " + potatoGram + " - Total Price: " + potatoTotalPrice + " AZN"); ;
            Console.WriteLine("Tomato - " + "Price: " + tomatoPrice + " - Gram: " + tomatoGram + " - Total Price: " + tomatoTotalPrice + " AZN"); ;

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Shopping Total Price: - "+shoppingTotalPrice + " AZN");

            Console.Read();
            #endregion
        }
    }
}
