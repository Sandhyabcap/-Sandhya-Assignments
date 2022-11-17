using System;
using System.Data.SqlClient;
// provider namespace
using System.Linq.Expressions;

namespace connectingDB
{
    class program1
    {
        static void Main(String[] args)
        {
            SqlConnection sqlConnection;
            string connectionString = @"Data Source = lsandyabVM; Initial Catalog = connect;Integrated Security = True";
            //connection  string
            try
            {
                sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                Console.WriteLine("\n\n\n\n************connection established successfully***********");


            }


            catch (Exception e)
            {

                Console.WriteLine(e.Message);

            }
        }

    }
}