using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******   Menu Order Processing Panel   *******");
            Console.WriteLine();

            Console.WriteLine("------------------------------------------------");

            #region Product List

            //SqlConnection connection = new SqlConnection("Data Source=localhost;" +
            //    " initial catalog=BootCampDB; integrated security=true");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("Select * from ProductTBL", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);
            //connection.Close();

            //foreach (DataRow row in dt.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Add Product
            //Console.Write("Enter Product Name: ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter Product price: ");
            //string productPrice = Console.ReadLine();
            //SqlConnection conn = new SqlConnection("Data Source=localhost; " +
            //    "initial catalog=BootCampDB; integrated security=true");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Insert into ProductTBL (ProductName, ProductPrice, ProductStatus) " +
            //    "values (@productName, @productPrice, @productStatus)", conn);
            //cmd.Parameters.AddWithValue("@productName", productName);
            //cmd.Parameters.AddWithValue("@productPrice", productPrice);
            //cmd.Parameters.AddWithValue("@productStatus", true);

            //cmd.ExecuteNonQuery();
            //conn.Close();

            //Console.WriteLine("Success");



            #endregion

            #region Update Product

            //Console.Write("Select Product Id you want to update: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Enter Product Name: ");
            //string productName = Console.ReadLine();

            //Console.Write("Enter Product Price: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=localhost;" +
            //    " initial catalog=BootCampDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update ProductTBL set " +
            //    "ProductName=@productName, ProductPrice=@productPrice where Id=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Update successfuly");

            #endregion

            #region Delete Product

            Console.Write("Select Product Id you want to remove");
            int productId = int.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=localhost;" +
               " initial catalog=BootCampDB; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Delete from ProductTBL where Id=@productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("Delete successfuly");
            #endregion

            Console.ReadKey();
        }
    }
}
