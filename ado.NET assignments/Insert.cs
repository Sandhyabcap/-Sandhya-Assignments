using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT
{
    internal class I
    {

        static void Main(string[] args)
        {

            SqlConnection sqlConnection;
            string connectionString = @"Data Source=lsandyabVM;Initial Catalog=connect;Integrated Security=True";

            try
            {


                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("\n\n\n*********connection established successfully*********");

                Console.WriteLine("\n\n\n\nPlease Enter Employee Id : ");
                int EId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nPlease Enter Employee First Name : ");
                String Firstname = Console.ReadLine();

                Console.WriteLine("\nPlease Enter Employee Last Name : ");
                String Lastname = Console.ReadLine();

                Console.WriteLine("\nPlease Enter Employee Salary : ");
                String Salary = Console.ReadLine();


                string insertQuery = "insert into Employees(EId, Firstname, Lastname , Salary) Values('" + EId + "','" + Firstname + "','" + Lastname + "','" + Salary + "') ";
                SqlCommand insertCommand = new SqlCommand(insertQuery, sqlConnection);
                insertCommand.ExecuteNonQuery();
                Console.WriteLine("Data Inserted");
                sqlConnection.Close();

            }


            catch (Exception e)

            {

                Console.WriteLine(e.Message);

            }
        }

    }
}