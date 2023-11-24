namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling different methods
            Add();

            // Calling a method with parameters and storing the result
            var result = Add2(10, 20);

            // Calling a method with different parameters and storing the result
            var result2 = Multiply(10, 20);

            // Calling a method with variable number of parameters and storing the result
            var result3 = Add3(2, 3, 5, 6, 1, 5);
        }

        // Simplest form of a method declaration
        static void Add()
        {
            // Implementation of the method goes here
        }

        // Method with parameters and a return type
        static int Add2(int number1 = 10, int number2 = 30)
        {
            // We specify the return type instead of void
            // We can use default parameters for flexibility
            return number1 + number2;
        }

        // Another method with parameters and a return type
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        // Method with a variable number of parameters using 'params' keyword
        static int Add3(params int[] numbers)
        {
            // Perform operations on the variable number of parameters
            return numbers.Sum();
        }
    }
}
