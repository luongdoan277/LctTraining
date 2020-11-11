using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosDbImplementation
{
    class Program
    {
        private static DocumentClient client;
        static string databaseId = "trainingdb";
        static void Main(string[] args)
        {
            var endpointUrl = "https://lcttrainingcosmosdb.documents.azure.com:443/";
            var key = "ILUS8zEQkZwkJCB639uL9XNe651ShE4GgS01AMb032WtoDdR1RDRZRUlo4iMHOjMuvmV06uoiA6SeRFlp9ig6A==";
            using (client = new DocumentClient(new Uri(endpointUrl), key))
            {
                CosmosDbDemo().Wait();
            }
            Console.ReadLine();
        }
        //Create a database if it does not exist
        public static async Task CosmosDbDemo()
        {
            Database database = client.CreateDatabaseQuery()
                .Where(db => db.Id == databaseId).AsEnumerable().FirstOrDefault();
            Console.WriteLine("Query for a database: {0}",
                database == null ? "no results" : database.Id);
            //check if a database was returned
            if (database == null)
            {
                // Create a Database
                database = await client.CreateDatabaseAsync(new Database { Id = databaseId });
                Console.WriteLine("\nCreated Database: id - {0}",
                    database.Id);
            }
        }
    }
}
