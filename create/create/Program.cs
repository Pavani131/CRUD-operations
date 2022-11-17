using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace create
{
    internal class Program
    {
       
        
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source =.; database = student;integrated security = True");

            try
            {
                SqlCommand cm = new SqlCommand("create table student(id int Not Null,name varchar(100),email varchar(50),join_date date)", con);
                con.Open();
                    cm.ExecuteNonQuery();
                Console.WriteLine("Executed Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("Oops something went wrong" +e);
            }
            finally
            {
                con.Close();
            }

            

            
        }
    }
}
