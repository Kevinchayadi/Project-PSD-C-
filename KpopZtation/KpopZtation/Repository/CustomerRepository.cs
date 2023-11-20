using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class CustomerRepository
    {
        Database1Entities db = Singelton.getInstance();
        public List<Customer> getAllCustomer()
        {
            return (from Customer in db.Customers select Customer).ToList();
        }

        public Customer findAccount(String email, String password)
        {
            return (from Customer in db.Customers where Customer.CustomerEmail == email && Customer.CustomerPassword == password select Customer).FirstOrDefault();
        }


        public Customer findEmail(String email)
        {
            return ((from Customer in db.Customers where Customer.CustomerEmail == email select Customer).FirstOrDefault());
        }

        public void registerCustomer(Customer custo)
        {
            db.Customers.Add(custo);
            db.SaveChanges();
        }

        public Customer UpdateCustomer(Customer custo, int id)
        {
            Customer data = db.Customers.Find(id);
            data.CustomerName = custo.CustomerName;
            data.CustomerEmail = custo.CustomerEmail;
            data.CustomerGender = custo.CustomerGender;
            data.CustomerPassword = custo.CustomerPassword;
            data.CustomerAddress = custo.CustomerAddress;
            db.SaveChanges();
            return data;
        }
    }
}