using System;
using System.Data.SqlClient;

namespace SqlConnectToCSharp
{
    internal class Program
    {
        private static void Main()
        {
            SqlConnection sqlConnection =
                new SqlConnection("Server = localhost; Database = People; Integrated Security = True;");

            using (sqlConnection)
            {
                sqlConnection.Open();
                using (SqlCommand sqlCommand = new SqlCommand("select * from Friend", sqlConnection))
                {
                    using (var sqlDataReader = sqlCommand.ExecuteReader())
                    {
                        while (sqlDataReader.Read())
                        {
                            Console.WriteLine("{0} {1}", sqlDataReader[0], sqlDataReader[1]);
                        }
                    }
                }
            }
        }
    }
}
    

