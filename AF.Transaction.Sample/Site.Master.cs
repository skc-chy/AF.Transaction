using System;
using System.Web.UI;

namespace SampleApplication
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionDemo.aspx");
        }

        protected void lnkWCFTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("WCFTransactionDemo.aspx");
        }
    }
}
