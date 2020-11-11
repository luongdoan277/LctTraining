using System;
using System.Data.SqlClient;

namespace LctTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=tcp:lctdatabase.database.windows.net,1433;Initial Catalog=lctdatabase;Persist Security Info=False;User ID=adminlct;Password=Abc@1234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("select * from TrainingTable", conn);
                    var readRows = cmd.ExecuteReader();
                    while (readRows.Read())
                    {
                        Console.WriteLine("Id: {0}; Training Name: {1}; Training Provider: {2} \n", readRows["Id"],
                            readRows["TrainingName"], readRows["TrainingProvider"]);
                    }                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
}
