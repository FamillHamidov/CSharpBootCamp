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

            //Console.WriteLine("*****  Price List  *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Apple price:" + applePrice + " AZN");
            //Console.WriteLine("---- Orange price:" + orangePrice + " AZN");
            //Console.WriteLine("---- Strawberry price" + strawberryPrice + " AZN");
            //Console.WriteLine("---- Potato price" + potatoPrice + " AZN");
            //Console.WriteLine("---- Tomato price" + tomatoPrice + " AZN");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.2;
            //orangeGram = 2.3;
            //strawberryGram = 3.4;
            //potatoGram = 2.6;
            //tomatoGram = 4.5;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Apple - " + "Price: " + applePrice + " - Gram: " + appleGram + " - Total Price: " + appleTotalPrice + " AZN"); ;
            //Console.WriteLine("Orange - " + "Price: " + orangePrice + " - Gram: " + orangeGram + " - Total Price: " + orangeTotalPrice + " AZN");
            //Console.WriteLine("Strawberry - " + "Price: " + strawberryPrice + " - Gram: " + strawberryGram + " - Total Price: " + strawberryTotalPrice + " AZN"); ;
            //Console.WriteLine("Potato - " + "Price: " + potatoPrice + " - Gram: " + potatoGram + " - Total Price: " + potatoTotalPrice + " AZN"); ;
            //Console.WriteLine("Tomato - " + "Price: " + tomatoPrice + " - Gram: " + tomatoGram + " - Total Price: " + tomatoTotalPrice + " AZN"); ;

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Shopping Total Price: - " + shoppingTotalPrice + " AZN");


            #endregion

            #region Data Entry from the keyboard, string variables

            //Console.WriteLine("*****   Airlines Passenger Information   *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.WriteLine("Passenger Name");
            //passengerName = Console.ReadLine();

            //Console.WriteLine("Passenger Surname");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("Passenger Age");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("City Information");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Passenger Identity Number");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------------------------");
            //Console.WriteLine("Passenger Identity Number - " + passengerIdentityNumber + " - Passenger Name: " + passengerName +
            //    " - Passenger Surname: " + passengerSurname + " - Passenger Age: " + passengerAge + " - Passenger City: " + passengerCity);


            #endregion

            #region Integer input and conversions from the keyboard

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 30;
            //computerPrice = 1500;
            //chairPrice = 50;
            //tvPrice = 2000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.WriteLine("Please enter the number of shoes you purchased: ");
            //shoesCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Please enter the number of computers you purchased: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Please enter the number of chairs you purchased: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Please enter the number of tv you purchased: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrice = shoesPrice * shoesCount + computerCount * computerPrice + chairPrice * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Amount You Need to Pay: " + totalPrice + " AZN");

            #endregion

            #region Decimal Number Operations from the Keyboard

            double exam1, exam2, exam3, result;

            Console.WriteLine("Please enter your 1st Exam grade: ");
            exam1 =double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter your 2st Exam grade: ");
            exam2 =double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter your 3st Exam grade: ");
            exam3 =double.Parse(Console.ReadLine());
            Console.WriteLine();

            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Your Exam Average: "+result);
            #endregion

            Console.Read();
        }
    }
}
