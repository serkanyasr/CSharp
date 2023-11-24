namespace Inheritance
{
    class Inheritance
    {
        public static void Main(string[] args)
        {
            // Create an array of Person objects
            Person[] persons = new Person[2]
            {
                new Person { FirstName = "Serkan" },
                new Customer { FirstName = "Yasar" }
            };

            // Iterate through the array and print the FirstName of each object
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }

    // Person class definition
    class Person
    {
        // Properties of the Person class
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    // Customer class definition inheriting from Person
    class Customer : Person
    {
        // Additional property specific to Customer
        public string City { get; set; }
    }

    // Student class definition
    class Student
    {
        // Property specific to Student
        public string Department { get; set; }
    }
}
