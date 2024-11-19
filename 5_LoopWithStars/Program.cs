using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_LoopWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 10 stars below each other

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("*");
            //}
            #endregion

            #region 10 stars side by side

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("*");
            //}
            #endregion

            #region 10 stars below each other. 10 stars per line

            //for (int i = 1; i < 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}
            #endregion

            #region Right triangle

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region İnverted right triangle

            //for (int i = 10; i >=1 ; i--)
            //{
            //    for (int j = 1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Right triangle and inverted right triangle

            //for (int i = 1; i <=10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 9; i >=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Pyramid

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 10-i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            #endregion

            #region Inverted pyramid 

            for (int i = 9; i >= 1; i--)
            {
                //boşluklar
                for (int j = 10 - i; j > 0; j--)
                {
                    Console.Write(" ");
                }

                //yıldızlar
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            #endregion
            Console.Read();
        }
    }
}
