using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Basic Arrays Example

            //string[] colors = new string[5];
            //colors[0] = "red";
            //colors[1] = "green";
            //colors[2] = "blue";
            //colors[3] = "yellow";
            //colors[4] = "gray";
            //Console.WriteLine(colors[2]);

            //string[] cities = new string[4];
            //cities[0] = "Baku";
            //cities[1] = "New York";
            //cities[2] = "Paris";
            //cities[3] = "Shangai";
            //Console.WriteLine(cities[1]);

            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;
            //numbers[3] = 4;
            //numbers[4] = 5;
            //Console.WriteLine(numbers[4]);

            //string[] colors = new string[5];
            //colors[0] = "red";
            //colors[1] = "green";
            //colors[2] = "blue";
            //colors[3] = "yellow";
            //colors[4] = "gray";

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //char[] symbols = { '!', '@', '#', '$', '%' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //int maxNumber = numbers[0];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > maxNumber)
            //    {
            //        maxNumber = numbers[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);


            #endregion

            #region Arrays Methods


            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //int index=Array.IndexOf(numbers, 34);
            //Console.WriteLine(index);

            //int[] numbers = { 23, 25, 34, 12, 21, 45 };
            //Console.WriteLine("Max = " + numbers.Max());
            //Console.WriteLine("Min = " + numbers.Min());
            #endregion

            #region Getting Value From User

            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Please enter {i + 1} city: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 1, 2, 3, 4, 5 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 45, 87, 14, 845, 656, 7 };
            // Console.WriteLine("Even Numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Odd Numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==1)
            //    {
                   
            //        Console.WriteLine(numbers[i]);
            //    }
            //}  
            #endregion
            Console.ReadKey();
        }
    }
}
