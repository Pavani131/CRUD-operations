using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source =.;database = student;integrated security = true");
            try
            {
                SqlCommand cm = new SqlCommand("insert into student(id,name,email,join_date) values ('102','pavani','pavani@gmail.com','5/10/2022')", con);
                con.Open();
                cm.ExecuteNonQuery();
                Console.WriteLine("inserted successfully");

            }
            catch (Exception e)
            {
                Console.WriteLine("Oops something went wrong" + e);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
