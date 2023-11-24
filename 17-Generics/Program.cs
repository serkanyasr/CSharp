using System;
using System.Collections.Generic;

namespace Generics
{
    class Generics
    {
        static void Main(string[] args)
        {
            // Utilities class instance is created.
            Utilities utilities = new Utilities();

            // BuidList method of the utilities object is called with some sample values.
            // BuidList method creates a generic list.
            List<string> result = utilities.BuidList<string>("Ankara", "Bursa");

            // Instances of the Customer class are passed to the BuidList method of the utilities object.
            // As a result, a generic list of type Customer is created.
            List<Customer> result2 = utilities.BuidList<Customer>(new Customer { FirstName = "Serkan" }, new Customer { FirstName = "Yelda" });

            // A loop is created to iterate over the created Customer list, and the FirstName property of each item is printed.
            foreach (var item in result2)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }

    // Generic class Utilities
    class Utilities
    {
        // BuidList method takes an array of items using the params keyword and returns them as a generic list.
        public List<T> BuidList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    // Product class
    class Product
    {

    }

    // Customer class
    class Customer
    {
        public string FirstName { get; set; }
    }

    // IRepository interface defines generic type operations.
    interface IRepository<T> where T : class, new()
    {
        List<T> GetAll();
        T Get(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int entity);
    }

    // IProductDal interface is derived from the IRepository interface and associated with the Product class.
    interface IProductDal : IRepository<Product>
    {

    }

    // ICustomerDal interface is derived from the IRepository interface and associated with the Customer class.
    interface ICustomerDal : IRepository<Customer>
    {

    }

    // ProductDal class is derived from the IProductDal interface and implements the methods of the IRepository interface.
    class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
