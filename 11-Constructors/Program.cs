namespace Constructors
{
    class Constructors
    {
        public static void Main(string[] args)
        {
            // Using overloaded constructors of CustomerManager
            CustomerManager customerManager = new CustomerManager();
            // customerManager.List();

            // Using the Product class with and without parameters
            Product product = new Product { Id = 19, Name = "Laptop" };
            Product product1 = new Product(); // It can also be used with default values through overload

            // Using EmployeeManager with different loggers
            EmployeeManager employeeManager = new EmployeeManager(new DatabaseLogger());
            // employeeManager.Add();

            EmployeeManager employeeManager1 = new EmployeeManager(new FileLogger());
            // employeeManager1.Add();

            // Using PersonManager which inherits from BaseClass
            PersonManager personManager = new PersonManager("Hello");
            personManager.Add();
        }
    }

    // CustomerManager class definition
    class CustomerManager
    {
        private int _count = 15;  // If no parameter is passed, it is assigned as 15

        // Constructor with a parameter
        public CustomerManager(int count)
        {
            _count = count;
        }

        // Default constructor with no parameters
        public CustomerManager()
        {

        }

        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }

        public void Add()
        {
            Console.WriteLine("Added");
        }
    }

    // Product class definition
    class Product
    {
        // Default constructor
        public Product()
        {

        }

        // Constructor with parameters
        public Product(int Id, string Name)
        {
            Id = Id;
            Name = Name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }

    // ILogger interface definition
    interface ILogger
    {
        void Log();
    }

    // DatabaseLogger class implementing ILogger interface
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }

    // FileLogger class implementing ILogger interface
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged to File");
        }
    }

    // EmployeeManager class definition
    class EmployeeManager
    {
        private ILogger _logger;

        // Constructor with ILogger parameter
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }

        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added");
        }
    }

    // BaseClass definition
    class BaseClass
    {
        private string _entity;

        // Constructor with a parameter
        public BaseClass(string entity)
        {
            _entity = entity;
        }

        public void Messege()
        {
            Console.WriteLine(_entity);
        }
    }

    // PersonManager class inheriting from BaseClass
    class PersonManager : BaseClass
    {
        // Constructor with a parameter, calling the base class constructor
        public PersonManager(string entity) : base(entity)
        {

        }

        public void Add()
        {
            Console.WriteLine("Added");
            Messege();
        }
    }
}
