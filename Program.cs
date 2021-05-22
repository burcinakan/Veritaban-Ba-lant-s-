using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//veritabanı bağlantısı için kullanılan namespace'ler
using System.Data;
using System.Data.SqlClient;

namespace ADONET
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Veritabanı Bağlantısı Bölüm 1
            ////Bağlantı (Bağlantı için nesne oluşturma)
            //SqlConnection baglanti = new SqlConnection();

            ////Bağlantı yolu (nereye bağlanacağız)
            //baglanti.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated security=true";
            ////@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;user_id=*******;password=*******;"

            ////komut
            //SqlCommand komut = new SqlCommand();
            //komut.Connection = baglanti;

            ////komut metni
            //komut.CommandText = "SELECT COUNT(*) FROM Products";

            ////Bağlantı aç
            //baglanti.Open();

            ////komut çalıştır
            //int sayi = Convert.ToInt32(komut.ExecuteScalar()); //ExecuteScalar sadece 1 veri(bir hücre)

            ////Bağlatı KAPAT(Unutma!!!)
            //baglanti.Close();
            //Console.WriteLine("Ürün Sayısı = " + sayi);
            #endregion

            #region Veritabanı Bağlantısı Bölüm 2

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated security=true");
            //SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = "SELECT SUM(UnitPrice) FROM Products";
            //con.Open();
            //double toplam = Convert.ToDouble(cmd.ExecuteScalar());
            //Console.WriteLine(toplam);
            //con.Close();


            #endregion

            #region Veritabanı bağlantısı Bölüm 3

            //SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated security=true");
            //try
            //{
            //    SqlCommand cmd = con.CreateCommand();
            //    cmd.CommandText = "SELECT SUM(UnitPrice) FROM Products";
            //    con.Open();
            //    double toplam = Convert.ToDouble(cmd.ExecuteScalar());
            //    Console.WriteLine(toplam);
            //}
            //finally
            //{
            //    con.Close();
            //}

            #endregion

            #region Veritabanı bağlantısı Bölüm 4

            using (SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated security=true"))
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "SELECT COUNT(*) FROM Products";

                con.Open();
                int adet = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine(adet);
            }

            #endregion


        }
    }
}
