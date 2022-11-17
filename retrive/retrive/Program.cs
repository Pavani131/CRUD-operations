using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retrive
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("data source =.;database = student; integrated security = true");
            con.Open();
            try
            {
                SqlCommand cm = new SqlCommand("select * from student",con);
                SqlDataReader dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine(dr["id"] + "" + dr["name"] + "" + dr["email"]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("oops something went wrong" + e);
            }
            finally
            {
                con.Close();
            }
            Console.ReadLine();
            
            

            
            
        }
    }
}
