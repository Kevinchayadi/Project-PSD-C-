using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class TransactionPage : System.Web.UI.Page
    {
        TransactionHandler th = new TransactionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer custo = (Customer)Session["user"];
            List<TransactionHeader> data = th.GetData(custo.CustomerID);
            GridView1.DataSource = data;
            GridView1.DataBind();

        }
    }
}