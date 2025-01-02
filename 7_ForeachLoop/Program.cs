using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exam Application

            Console.WriteLine("******* C# Exam Application *******");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("------------------------------");
            Console.Write("Enter the number of students in the class: ");
            int studentcount=int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            string[] studentNames=new string[studentcount];
            double[] studentExamAvg=new double[studentcount];

            for (int i = 0; i <studentcount; i++)
            {
                Console.Write($"Please enter {i+1} student name: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0;
                 
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Please enter {j+1} exam of the student named {studentNames[i]}: ");
                    double value=double.Parse(Console.ReadLine());
                    totalExamResult += value;
                }
                studentExamAvg[i] = totalExamResult / 3;

            }
            Console.WriteLine();
            Console.WriteLine("------------------------------");
            for (int i = 0; i < studentcount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"{studentNames[i]} student's exam grade {studentExamAvg[i]}]");
                if (studentExamAvg[i]>50)
                {
                    Console.WriteLine($"Student named {studentNames[i]} succeeded the exam");
                }
                else
                {
                    Console.WriteLine($"Student named {studentNames[i]} failes the exam");
                }
                Console.WriteLine("------------------------------");
            }
            #endregion
            Console.ReadKey();
        }
    }
}
