using KpopZtation.Factory;
using KpopZtation.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Handler
{
    public class LoginRegisterHandler
    {
        CustomerRepository tr = new CustomerRepository();

        public Customer findAccount(String email, String password)
        {
            Customer custo = tr.findAccount(email, password);

            return custo;
        }

        public Customer findEmail(String email)
        {
            Customer custo = tr.findEmail(email);
            return (custo);
        }
        public void insertAccount(String name, String email, String password, String gender, String address, String role)
        {
            Customer custo = CustomerFactory.createCustomer(name, email, password, gender, address, role);
            tr.registerCustomer(custo);

        }
        public Customer UpdatetAccount(String name, String email, String password, String gender, String address, String role, int id)
        {
            Customer custo = CustomerFactory.createCustomer(name, email, password, gender, address, role);
            return tr.UpdateCustomer(custo, id);

        }
    }
}