using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Factory
{
    public class CustomerFactory
    {
        public static Customer createCustomer(String Name, String Email, String Password, String Gender, String Address, String Role)
        {
            Customer custo = new Customer();

            custo.CustomerAddress = Address;
            custo.CustomerEmail = Email;
            custo.CustomerGender = Gender;
            custo.CustomerName = Name;
            custo.CustomerPassword = Password;
            custo.CustomerRole = Role;

            return (custo);
        }
    }
}