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
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        LoginRegisterController tc = new LoginRegisterController();
        LoginRegisterHandler th = new LoginRegisterHandler();
        public Customer custo = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {
            custo = (Customer)Session["user"];
        }

        private void resetWarningLabel()
        {
            warningAddress.Text = "";
            warningEmail.Text = "";
            warningGender.Text = "";
            warningName.Text = "";
            warningPassword.Text = "";
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            resetWarningLabel();

            warningName.Text = tc.checkName(nameText.Text);
            warningEmail.Text = tc.checkEmail(emailText.Text);
            warningGender.Text = tc.checkGender(genderRadio.SelectedIndex);
            warningAddress.Text = tc.checkAddress(addressText.Text);
            warningPassword.Text = tc.checkPassword(passwordText.Text);


            if (warningName.Text == "" && warningEmail.Text == "" && warningGender.Text == "" && warningAddress.Text == "" && warningPassword.Text == "" && warningRole.Text == "")
            {
                Session["user"] = th.UpdatetAccount(nameText.Text, emailText.Text, passwordText.Text, genderRadio.SelectedItem.Text, addressText.Text, custo.CustomerRole, custo.CustomerID);

                Response.Redirect("HomePage.aspx");
            }
        }
    }
}