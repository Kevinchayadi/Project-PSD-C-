using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{

    public partial class NavBar : System.Web.UI.MasterPage
    {
        public Customer custo = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Application["usercount"] == null) Application["usercount"] = 0;
            if (Session["user"] != null)
            {
                custo = (Customer)Session["user"];
            }

        }

        protected void homeButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterPage.aspx");
        }

        protected void transactionButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionReportPage.aspx");
        }
        protected void transactionButtonCustomer_Click(object sender, EventArgs e)
        {
            Response.Redirect("TransactionPage.aspx");
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void logoutButton_Click(object sender, EventArgs e)
        {
            String[] cookies = Request.Cookies.AllKeys;
            Session.Remove("user");
            Session.RemoveAll();
            Session.Clear();
            Session.Abandon();

            foreach (String cookie in cookies)
            {
                Response.Cookies[cookie].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("loginPage.aspx");
        }

        protected void cartsButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("CartPage.aspx");
        }
    }
}