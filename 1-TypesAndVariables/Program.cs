namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Call the method to demonstrate different data types
            DataTypes();
        }

        public static void DataTypes()
        {
            // int data type
            int IntNumber = 0;

            // Long data type
            long LongNumber = 54646464;

            // Short data type
            short ShortNumber = 12;

            // Strings for storing textual data
            string name = "Serkan";
            string surname = "Yasar";

            // byte data type (range: 0-255)
            byte number = 121;

            // bool data type representing True or False
            bool IsTrue = true;
            bool IsFalse = false;

            // char data type representing a single character (enclosed in single quotes)
            char character = 'a';

            // double data type for decimal numbers
            double number4 = 3.5;

            // decimal data type used for precise decimal calculations, suffix 'm' is required
            decimal number5 = 2.6165161681981698545454456465m;

            // Var keyword used to implicitly declare variables
            var number7 = 15; // Here, 'var' is implicitly an int

            // Displaying the values using string interpolation
            Console.WriteLine("My name is: {0} Surname is: {1}", name, surname);
            Console.WriteLine("Int: {0}, Long: {1}, Short: {2}", IntNumber, LongNumber, ShortNumber);

            // Pause the console so that the output can be viewed
            Console.ReadLine();
        }
    }
}
