using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            Customer customer1 = new Customer { Id = 1 , FirstName = "kübra", LastName = "çelebi" , City = "istanbul"};

            Customer customer2 = new Customer(2, "ayşe", "yılmaz", "ankara");
        }
    }

    class Customer
    {
        //default constructor
        public Customer() 
        {
        }

        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}