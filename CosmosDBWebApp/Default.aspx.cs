using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI;

namespace CosmosDBWebApp
{
    public partial class _Default : Page
    {
        private static DocumentClient client;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Label1.Text = TextBox1.Text;

            var endpointUrl = "https://lcttrainingcosmos-db.documents.azure.com:443/";
            var key = "6KKLatH9syhZLi3i1qMRoG9gqE7BCLmRIptk0V313vELxSeK0VmTTqbGYj49CjBWPFE5qR3q9laaSomKZMMX0Q==";
            using (client = new DocumentClient(new Uri(endpointUrl), key))
            {
                CosmosDbDemo().Wait();
            }
        }

        public async Task CosmosDbDemo()
        {
            Database database = client.CreateDatabaseQuery()
                .Where(db => db.Id == TextBox1.Text).AsEnumerable().FirstOrDefault();

            Label1.Text = database == null ? " does not " : database.Id;
        }
    }
}