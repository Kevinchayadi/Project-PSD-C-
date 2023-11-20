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
    public partial class RegisterPage : System.Web.UI.Page
    {
        LoginRegisterController tc = new LoginRegisterController();
        LoginRegisterHandler th = new LoginRegisterHandler();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            resetWarningLabel();

            warningName.Text = tc.checkName(nameText.Text);
            warningEmail.Text = tc.checkEmail(emailText.Text);
            warningGender.Text = tc.checkGender(genderRadio.SelectedIndex);
            warningAddress.Text = tc.checkAddress(addressText.Text);
            warningPassword.Text = tc.checkPassword(passwordText.Text);
            warningRole.Text = tc.checkRole(roleList.SelectedValue);

            if (warningName.Text == "" && warningEmail.Text == "" && warningGender.Text == "" && warningAddress.Text == "" && warningPassword.Text == "" && warningRole.Text == "")
            {
                th.insertAccount(nameText.Text, emailText.Text, passwordText.Text, genderRadio.SelectedItem.Text, addressText.Text, roleList.SelectedValue.Substring(0, 5));
                registerSuccess.Text = "Account Registration Success";

                Response.Redirect("LoginPage.aspx");
            }
        }

        private void resetWarningLabel()
        {
            warningAddress.Text = "";
            warningEmail.Text = "";
            warningGender.Text = "";
            warningName.Text = "";
            warningPassword.Text = "";
        }
    }
}