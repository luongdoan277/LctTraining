using System;
using System.Linq;
using System.Web.UI;

namespace EntityFrameworkInWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (lctdatabaseEntities lctTrainingentity = new lctdatabaseEntities())
                {
                    //Add data to a table
                    lctTrainingentity.TrainingTables.Add(new TrainingTable { Id = 1, TrainingName = "LCT", TrainingProvider = TextBox1.Text });
                    //Using DBContext (named lctTrainingentity) object to save to a table
                    lctTrainingentity.SaveChanges();

                    //LINQ to search from a table to display the inserted record
                    var findSuzan = lctTrainingentity.TrainingTables.Where(x => x.TrainingProvider.Equals(TextBox1.Text))
                            .FirstOrDefault();

                    Label1.Text = Convert.ToString(findSuzan.Id);
                    Label2.Text = findSuzan.TrainingName;
                    Label3.Text = findSuzan.TrainingProvider;
                }
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
        }
    }
}