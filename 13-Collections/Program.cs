using System;
using System.Collections.Generic;

namespace Collections
{
    class Collections
    {
        public static void Main(string[] args)
        {
            // Example code for using List
            // List(); // This line is commented out and currently inactive.

            // Dictionary collection definition and adding sample values
            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            // Adding a value for the key "book"
            dictionary.Add("book", "Kitap");

            // Adding a value for the key "table"
            dictionary.Add("table", "Tablo");

            // Adding a value for the key "computer"
            dictionary.Add("computer", "Bilgisayar");

            // Retrieving the value for the key "table"
            var valueTable = dictionary["table"];

            // Iterating through the entire dictionary and printing values
            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Value);
            }

            // Checking if the key "glass" exists in the dictionary
            bool IsGlass = dictionary.ContainsKey("glass");

            Console.WriteLine(IsGlass);
        }

        private static void List()
        {
            // Example code for using List

            // Creating a List of type Customer
            List<Customer> customers = new List<Customer>();

            // Adding a customer to the list
            customers.Add(new Customer { Id = 1, FirstName = "Serkan" });

            // Alternative way of creating a list and adding a customer
            List<Customer> customers1 = new List<Customer>
            {
                new Customer { Id = 2, FirstName = "Serkan" },
            };

            // Getting the count of elements in the list
            var count = customers.Count;

            // Creating a new customer and adding it to the list
            var customer1 = new Customer
            {
                Id = 3,
                FirstName = "Salih"
            };
            customers.Add(customer1);

            // Adding multiple customers at once using AddRange
            customers.AddRange(new Customer[2]
            {
                new Customer { Id = 34, FirstName = "Serkan" },
                new Customer { Id = 34, FirstName = "Serkan" }
            });

            // Uncomment the line below to clear the entire list (currently commented out)
            // customers.Clear();

            // Checking if a specific customer is in the list
            bool containsCustomer = customers.Contains(customer1);

            // Getting the first index where a specific customer is found
            var index = customers.IndexOf(customer1);
            Console.WriteLine(index);

            // Getting the last index where a specific customer is found
            var lastIndex = customers.LastIndexOf(customer1);

            // Inserting a customer at a specific index
            customers.Insert(1, customer1);

            // Removing a specific customer from the list
            customers.Remove(customer1);

            // Removing all customers that satisfy a specific condition using RemoveAll
            customers.RemoveAll(c => c.FirstName == "Serkan");

            // Iterating through the list and printing customers to the console
            foreach (var item in customers)
            {
                Console.WriteLine("{0}-{1}", item.Id, item.FirstName);
            }
        }
    }

    class TypeSafeList
    {
        public static void List()
        {
            // Example of creating a type-safe list using List<string>

            List<string> cities = new List<string>(); // Accepts only strings

            // Adding a city named "Ankara" to the list
            cities.Add("Ankara");
        }
    }

    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
