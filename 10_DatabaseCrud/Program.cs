using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud = create-read-update-delete

            Console.WriteLine("******Menü Sipariş İşlem Paneli*******");
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.WriteLine("eklemek istediğiniz kategori adı:");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=NARIN\\SQLEXPRESS ;inital Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryNsme) values(@p1)", connection);
            //command.Parameters.AddWithValue("@pl", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.Write("kategori başarıyla eklendi");
            #endregion

            #region   Ürün Listeleme


            //SqlConnection connection = new SqlConnection("Data Source=NARIN\\SQLEXPRESS;inital catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //    DataTable dataTable=new DataTable();
            //adapter.Fill(dataTable);


            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.WriteLine(item.ToString()+"");
            //    }
            //    Console.WriteLine() ;
            //}
            //connection.Close();


            #endregion


            #region Ürün Silme İşleme
            //Console.Write("silinecek ürün ıd:");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NARIN\\SQLEXPRESS;inital Catalog=EgitimKampiDb;integrated security=true");
            // connection.Open();


            //SqlCommand command = new SqlCommand(" Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("silme işlemi yapıldı");

            #endregion
            #region Ürün güncelleme işlemi


            //Console.WriteLine("güncellenecek ürün ıd:");
            //int productId=int.Parse(Console.ReadLine());

            //Console.WriteLine("Güncellenecek ürün adı:");
            //string productName = Console.ReadLine();

            //Console.WriteLine("güncellenecek ürün fiyatı:");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=NARIN\\SQLEXPRESS;inital catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand(" Update TblProduct Set ProductBame=@productName,ProductPrice=@productPrice where ProductId=productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("güncelleme başarılı");




            #endregion

        }
    }
}
