using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(ref List<Customer> customers)
        {
            Customer customerCreate = new Customer();

            Console.WriteLine("Customer Id : ");
            customerCreate.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer FisrtName : ");
            customerCreate.FirstName = Console.ReadLine();
            Console.WriteLine("Customer LastName : ");
            customerCreate.LastName = Console.ReadLine();
            Console.WriteLine("Customer PhoneNumber : ");
            customerCreate.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Customer CreditCardNumber : ");
            customerCreate.CreditCardNumber = Console.ReadLine();
            customers.Add(customerCreate); //customers listemizin içerisine yeni oluşturduğumuz customerı ekledik
            Console.WriteLine("Eklendi!");
            Console.ReadLine();
        }

        public void ListCustomer(ref List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customer Id : " + customer.Id);
                Console.WriteLine("Customer FisrtName : " + customer.FirstName);
                Console.WriteLine("Customer LastName : " + customer.LastName);
                Console.WriteLine("Customer PhoneNumber : " + customer.PhoneNumber);
                Console.WriteLine("Customer CreditCardNumber : " + customer.CreditCardNumber);
                Console.WriteLine();
            }

        }
        public void DeleteCustomer(ref List<Customer> customers, int i)
        {
            customers.Reverse();
            Console.WriteLine("Silinmesini istediğiniz Customer Id numarası?");
            i = Convert.ToInt32(Console.ReadLine());
            customers.RemoveAt(customers.Capacity - i);
            Console.WriteLine("Id Numarası " + i + " olan customer silindi!");
            customers.Reverse();
        }
    }
}
