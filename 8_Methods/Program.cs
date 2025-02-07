
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methods

            //void CustomerList()
            //{
            //    Console.WriteLine("Famil Hemidli");
            //    Console.WriteLine("Tural Hemidli");
            //}

            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 3;
            //    int y=5;
            //    Console.WriteLine(x + y);
            //}

            //Sum();

            #endregion

            #region String parametres Void Methods

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Famil Hemidli");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Customer: " + name + " " + surname);
            //}

            //CustomerCard("Famil", "Hemidli");
            #endregion

            #region Int parametres Void Methods

            //void Sum(int number, int number2, int number3)
            //{
            //    int result=number+number2+number3;
            //    Console.WriteLine(result);
            //}

            //Sum(1,2,3);
            #endregion

            #region Return a value methods

            //string CustomerName()
            //{
            //    return "Famil Hemidli";
            //}

            //Console.WriteLine(CustomerName());


            #endregion

            #region Return a value methods with string parametres

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string countryInfo = "Country: " + countryName + " Capital: " + capital + " Flag Color: " + flagColor;
            //    return countryInfo;
            //}

            //string x, y, z;
            //Console.Write("Enter country name: ");
            //x= Console.ReadLine();

            //Console.Write("Enter capital name: ");
            //y= Console.ReadLine();

            //Console.Write("Enter flag color: ");
            //z= Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Azerbaycan", "Baki", "Goy-Qirmizi-Yasil"));

            #endregion

            #region Return a value methods with int parametres

            //int Sum(int number1,int number2)
            //{
            //    int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(5,10));
            //Console.WriteLine(Sum(7,5));
            //Console.WriteLine(Sum(6,9));
            #endregion

            #region Sample App

            string ExamResult(string studentName, int exam1, int exam2, int exam3)
            {
                int examResult = (exam1 + exam2 + exam3) / 3;
                if (examResult>50)
                {
                    return studentName + " exam passed successfuly";
                }
                else
                {
                    return studentName + " failed the exam";
                }
            }

            Console.WriteLine(ExamResult("Famil", 50,75,66));
            #endregion



            Console.ReadKey();
        }
    }
}
