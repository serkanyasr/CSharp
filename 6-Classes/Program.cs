namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the CustomerManager class
            CustomerManager customerManager = new CustomerManager();

            // Call methods of the CustomerManager class
            customerManager.Add();
            customerManager.Update();

            // Properties

            // Create an instance of the Customer class
            Customer customer = new Customer();

            // Set values for properties of the Customer class
            customer.FirstName = "Serkan";
            customer.LastName = "Yasar";
            customer.Id = 1;
            customer.City = "Bursa";

            // Create another instance of the Customer class using an object initializer
            Customer customer1 = new Customer
            {
                City = "Ankara",
                FirstName = "Serkan1",
                LastName = "Yasar1",
            };

            // Display the value of a property
            Console.WriteLine(customer1.FirstName);
        }
    }

    // CustomerManager class definition
    class CustomerManager
    {
        public void Add()
        {
            // Implementation of the Add method goes here
        }

        public void Update()
        {
            // Implementation of the Update method goes here
        }
    }

    // Customer class definition
    class Customer
    {
        // Properties of the Customer class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
