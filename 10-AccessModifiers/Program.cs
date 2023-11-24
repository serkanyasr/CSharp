namespace AccessModifiers
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create an instance of the Student class
            Student student = new Student();

            // Call the Save method of the Student class
            student.Save();
        }
    }

    // Customer class definition
    class Customer
    {
        private int Id;  // Can only be used within the declared class
        protected int Id2;  // Can be used in deriving classes (through inheritance)
        internal int Id3;  // Can be used within the same assembly

        // Public method accessible from other classes
        public void CustomerSet()
        {
            Console.WriteLine("CustomerSet");
        }

        // Public method with a local variable
        public void Delete()
        {
            int Id = 10;
            Console.WriteLine(Id);
        }
    }

    // Student class definition
    class Student
    {
        // Public method to demonstrate accessing methods and properties of another class
        public void Save()
        {
            // Create an instance of the Customer class
            Customer customer = new Customer();

            // Access public methods of the Customer class
            customer.CustomerSet();
            customer.Delete();
        }
    }

    // Internal class definition (default is internal)
    internal class Course
    {
        // Members of this class are accessible within the same assembly
    }
}
