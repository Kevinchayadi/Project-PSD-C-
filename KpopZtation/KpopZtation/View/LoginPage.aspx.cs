using KpopZtation.Controller;
using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KpopZtation.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        LoginRegisterController tc = new LoginRegisterController();
        LoginRegisterHandler th = new LoginRegisterHandler();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            resetWarningLabel();

            warningEmailLabel.Text = tc.checkEmailNull(emailText.Text);
            warningPasswordLabel.Text = tc.checkPasswordNull(passwordText.Text);

            if (warningEmailLabel.Text == "" && warningPasswordLabel.Text == "")
            {
                failLogin.Text = tc.checkAccount(emailText.Text, passwordText.Text);
                if (failLogin.Text == "")
                {
                    Customer data = new Customer();
                    data = th.findEmail(emailText.Text);
                    Session["user"] = data;


                    if (rememberMe.Checked == true)
                    {
                        HttpCookie userCookie = new HttpCookie("userCookie");
                        userCookie.Value = emailText.Text.ToString();
                        userCookie.Expires = DateTime.Now.AddDays(30);
                        Response.Cookies.Add(userCookie);
                    }
                    Response.Redirect("HomePage.aspx");
                }
            }
        }
        private void resetWarningLabel()
        {
            warningEmailLabel.Text = "";
            warningPasswordLabel.Text = "";
            failLogin.Text = "";
        }
    }
}