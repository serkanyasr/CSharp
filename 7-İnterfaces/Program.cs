namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the PersonManager class
            PersonManager personManager = new PersonManager();

            // Create a Customer object
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Serkan",
                LastName = "Yasar"
            };

            // Create a Student object
            Student student = new Student
            {
                Id = 1,
                FirstName = "Serkan",
                LastName = "Yasar",
                Department = "Software"
            };

            // Call the Add method of PersonManager with a Customer object
            personManager.Add(customer);
        }
    }

    // IPerson interface definition
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    // Customer class definition implementing IPerson interface
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Student class definition implementing IPerson interface
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    // PersonManager class definition
    class PersonManager
    {
        // Method to add a person (accepts objects implementing IPerson interface)
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
