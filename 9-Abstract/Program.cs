using System;

namespace Abstract
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creating objects derived from the abstract class Database.
            // These objects refer to different subclasses: MySql and SqlServer.
            Database database = new MySql();    // An object derived from the MySql class
            database.Add();                     // Calling a concrete method of the abstract class
            database.Delete();                  // Calling an abstract method of the abstract class

            Database database1 = new SqlServer(); // An object derived from the SqlServer class
            database1.Add();                      // Calling a concrete method of the abstract class
            database1.Delete();                   // Calling the abstract method of the SqlServer class
        }
    }

    // Abstract class definition
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Default behavior for Add is executed.");
        }

        // Defining an abstract method. Subclasses must implement this method.
        public abstract void Delete();
    }

    // SqlServer class definition inheriting from Database
    class SqlServer : Database
    {
        // The Delete method is implemented in the SqlServer class.
        public override void Delete()
        {
            Console.WriteLine("Deleting from Sql Server database.");
        }
    }

    // MySql class definition inheriting from Database
    class MySql : Database
    {
        // The Delete method is implemented in the MySql class.
        public override void Delete()
        {
            Console.WriteLine("Deleting from MySql database.");
        }
    }
}
