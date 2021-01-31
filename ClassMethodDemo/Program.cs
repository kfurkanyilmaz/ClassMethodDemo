using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Cem";
            customer1.LastName = "Yılmaz";
            customer1.PhoneNumber = "0555 111 11 11";
            customer1.CreditCardNumber = "4444-5555-****-****";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Furkan";
            customer2.LastName = "Yılmaz";
            customer2.PhoneNumber = "0555 222 22 22";
            customer2.CreditCardNumber = "3333-4444-****-****";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Yılmaz";
            customer3.LastName = "Erdoğan";
            customer3.PhoneNumber = "0555 333 33 33";
            customer3.CreditCardNumber = "5555-8888-****-****";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.FirstName = "Ali";
            customer4.LastName = "Erdoğan";
            customer4.PhoneNumber = "0555 444 44 44";
            customer4.CreditCardNumber = "5454-8181-****-****";

            


            List<Customer> customers = new List<Customer> { customer1, customer2, customer3,customer4};
            
            CustomerManager customerManager = new CustomerManager();
            //customerManager.AddCustomer(ref customers);
            customerManager.DeleteCustomer(ref customers, 0);
            customerManager.ListCustomer(ref customers);
        }   
    }
}
