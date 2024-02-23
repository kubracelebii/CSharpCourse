using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.FirstName = "Kübra";
            customer.LastName = "Çelebi";
            customer.Id = 1;
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "Ankara",
                FirstName = "Ayşe", //set
                LastName = "Yılmaz"
            };

            Console.WriteLine(customer2.FirstName); // get
            

            Console.ReadLine();
        }
    }
}
