using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Please enter password: ");
            //string password= Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Password is true");
            //}
            //else
            //{
            //    Console.WriteLine("Password is false");
            //}



            //string country, capital;
            //Console.Write("Enter the country: ");
            //country = Console.ReadLine();

            //Console.Write("Enter the capital: ");
            //capital = Console.ReadLine();

            //if (country=="azerbaycan" & capital=="baki")
            //{
            //    Console.WriteLine("Data verified");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect information");
            //}



            //int number;
            //Console.WriteLine("Enter the number");
            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Number is true");
            //}
            //else
            //{
            //    Console.WriteLine("Number is false");
            //}



            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Enter the Exam1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Enter the Exam2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Enter the Exam3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Exams average: "+average);

            //if (average>0 & average<=50)
            //{
            //    result = "Result is bad";
            //}
            //if (average>50 & average<=70)
            //{
            //    result = "Result is middle";
            //}
            //if (average>70 & average<=84)
            //{
            //    result = "Result is good";
            //}
            //if (average>84)
            //{
            //    result = "Result is very good";
            //}
            //Console.WriteLine(result);


            //Console.WriteLine("Enter the city: ");
            //string city = Console.ReadLine();
            //if (city=="baki" | city=="sumqayit" | city=="gence" | city=="seki")
            //{
            //    Console.WriteLine("City is true");
            //}
            //else
            //{
            //    Console.WriteLine("City is false");
            //}


            //Console.WriteLine("Enter your username: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.WriteLine("Username if false");
            //}
            //else
            //{
            //    Console.WriteLine("Username if true");
            //}


            #endregion

            #region Mod Operations

            //Console.Write("Please enter the first number: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("Please enter the second number: ");
            //int number2=int.Parse(Console.ReadLine());

            //int result=number1%number2;
            //Console.WriteLine("Result: "+result);


            //Console.Write("Please enter the number: ");
            //int number=int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}  
            #endregion

            #region Decision Structures with Char Variables

            //char team;
            //Console.Write("Please enter team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}


            #endregion

            #region Project

            //Console.WriteLine("*****    Restaurant    *****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("İsti yemekler");
            //Console.WriteLine("Sorbalar");
            //Console.WriteLine("Pizzalar");
            //Console.WriteLine("İckiler");
            //Console.WriteLine("Desertler");
            //Console.WriteLine("----------------------------");


            //string menuItem;

            //Console.Write("Select Menu: ");
            //menuItem = Console.ReadLine();

            //if (menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------   İsti yemekler   ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Toyuq langeti");
            //    Console.WriteLine("Et langeti");
            //    Console.WriteLine("Medalyon");
            //    Console.WriteLine("Sac Qarisiq");
            //}
            //if (menuItem=="2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------   Sorbalar   ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Merci sorbasi");
            //    Console.WriteLine("Gobelek sorbasi");
            //    Console.WriteLine("Tomat sorbasi");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------   Pizzalar   ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Pizza Margarita");
            //    Console.WriteLine("Pizza Qarisiq");
            //    Console.WriteLine("Pizza Peperoni");
            //    Console.WriteLine("Pizza Sezar");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------   İckiler   ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Cola/Fanta/Sprite");
            //    Console.WriteLine("Redbul");
            //    Console.WriteLine("İce Tea");
            //    Console.WriteLine("Meyve siresi");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------   Desertler   ----------");
            //    Console.WriteLine();
            //    Console.WriteLine("Tiramisu");
            //    Console.WriteLine("CheeseCake");
            //    Console.WriteLine("Dondurma");
            //    Console.WriteLine("Meyve Seti");
            //}

            #endregion

            #region Switch Case

            //Console.Write("Please enter month: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Number incorrect");
            //        break;
            //}
            #endregion

            #region Calculator with switch case

            int number1, number2, result;
            char symbol;

            Console.Write("Enter first number: ");
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            number2 = int.Parse(Console.ReadLine());

            Console.Write("Select the operation: ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine(result);
                    break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine(result);
                    break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine(result);
                    break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Operation incorrect");
                    break;
            }

            #endregion


            Console.Read();
        }
    }
}
