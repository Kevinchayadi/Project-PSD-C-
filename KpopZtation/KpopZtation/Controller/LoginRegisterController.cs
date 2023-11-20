using KpopZtation.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace KpopZtation.Controller
{
    public class LoginRegisterController
    {
        LoginRegisterHandler th = new LoginRegisterHandler();
        public String checkEmailNull(String email)
        {
            if (email == "")
            {
                return "Please input email";
            }
            return "";
        }

        public String checkPasswordNull(String password)
        {
            if (password == "")
            {
                return "Please input password";
            }
            return "";
        }

        public String checkAccount(String email, String password)
        {
            if (th.findAccount(email, password) != null)
            {
                return "";
            }


            return "Email or Password is Invalid";
        }

        public String checkName(String name)
        {
            if (name.Length < 5 || name.Length > 50)
            {
                return ("Please input name between 5 - 50 characters");
            }
            return "";
        }

        public String checkEmail(String email)
        {
            String warningEmail = checkEmailNull(email);
            if (warningEmail != "")
            {

                return warningEmail;
            }

            if (Regex.IsMatch(email, @"[a-zA-Z0-9_.+-]+@gmail\.com$") != true)
            {
                warningEmail = "Email must end with '@gmail.com'!!";
            }

            if (th.findEmail(email) != null)
            {
                warningEmail = "Email already registered for another account";
            }
            return warningEmail;
        }

        public String checkGender(int gender)
        {
            if (gender == -1)
            {
                return ("Please input your gender");
            }
            return "";
        }

        public String checkAddress(String address)
        {
            if (address == "")
            {
                return ("Please input your address");
            }

            if (address.Substring(Math.Max(address.Length - 6, 0)) != "Street")
            {
                return ("Please end your address with 'Street'");
            }

            return "";
        }

        public String checkPassword(String password)
        {
            String warningPassword = checkPasswordNull(password);
            if (warningPassword != "")
            {
                return warningPassword;
            }

            bool letter = false, number = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLetter(password[i]))
                {
                    letter = true;
                }
                else if (char.IsDigit(password[i]))
                {
                    number = true;
                }
            }

            if (letter && number)
            {
                warningPassword = "";
            }
            else
            {
                warningPassword = "Please input letter and number as password";
            }
            return warningPassword;
        }

        public String checkRole(String role)
        {
            if (role == "")
            {
                return "Please select a role";
            }
            return "";
        }
    }
}