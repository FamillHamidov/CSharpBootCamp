using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Product-Category Info System with C#");
            //Console.WriteLine();
            //Console.WriteLine();

            //string tableNumber;
            //Console.WriteLine("------------------------------");
            //Console.WriteLine("1--Category");
            //Console.WriteLine("2--Product");
            //Console.WriteLine("3--Order");
            //Console.WriteLine("4--Exit");
            //Console.Write("Please enter table number: ");
            //tableNumber = Console.ReadLine();
            //Console.WriteLine("------------------------------");

            //SqlConnection conn = new SqlConnection("Data Source=localhost; Initial catalog=BootCampDB;" +
            //    " integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * From CategoryTBL", conn);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //conn.Close();
            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString());
            //    }
            //    Console.WriteLine();
            //}


            Console.ReadKey();
        }
    }
}
