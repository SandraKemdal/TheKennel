using System;
using System.Threading;
using TheKennel.Data;
using TheKennel.Factory;

namespace TheKennel.KennelCustomers
{
    public class CustomerManager : ICustomerManager
    {
        public IDatabaseLists Db { get; set; }

        public CustomerManager(IDatabaseLists db)
        {
            Db = db;
        }

        public void CreateCustomer()
        {
            IPerson person = CustomerFactory.Create();
                          
            Console.WriteLine("Please enter your name here: ");
            string customerName = Console.ReadLine();
            person.Name = customerName;

            Console.WriteLine("\nPlease enter your phone number here: ");
            string phoneNo = Console.ReadLine();
            person.PhoneNo = phoneNo;

            Console.WriteLine($"\nWelcome {person.Name}!\n");
            Console.WriteLine("The registration was succesfully and you are now registreted as a new customer at Kemdal's Kennel!");
            Console.WriteLine("Don't do anything, you will automatically be transferred back to the Main Menu!");
            Db.PeopleList.Add(person);

            int millisec = 6000;
            Thread.Sleep(millisec);

            Console.Clear();
        }

        public void SeeAllRegisteredCustomers()
        {
            Console.WriteLine("List of all registerred customers: \n");

            foreach (var customer in Db.PeopleList)
            {
                Console.WriteLine($"Customer: {customer.Name}, {customer.PhoneNo}");
            }

            Console.WriteLine("");
        }
    }
}