using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPTado.net
{
    internal class Deletion
    {

        public static void Main(string[] args)
        {
            

            
                SqlConnection sqlConnection;
                string connectionString = @"Data Source=lsandyabVM; Initial Catalog=connect; Integrated Security=True";
                

                try
                { 
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                
                    Console.WriteLine("enter the id value that u want to delete ");
                    int EmpID = int.Parse(Console.ReadLine());

                    string deletequery = "delete from employeeData where EmpID=" + EmpID;
                    SqlCommand deleteCommand = new SqlCommand(deletequery, sqlConnection);


                    deleteCommand.ExecuteNonQuery();
                    Console.WriteLine("deleted data successfully");
                    sqlConnection.Close();
                   
                    
                   

                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                   Console.ReadLine();
        }


        
    }
}