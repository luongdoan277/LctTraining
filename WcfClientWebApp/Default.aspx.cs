using System;
using System.Web.UI;

namespace WcfClientWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ShowButton_Click(object sender, EventArgs e)
        {
            TrainingServiceReference.IService1 wcfServiceClient = new TrainingServiceReference.Service1Client();
            MessageLabelFromService.Text = wcfServiceClient.SayHello(MessageTextBox.Text);
        }
    }
}