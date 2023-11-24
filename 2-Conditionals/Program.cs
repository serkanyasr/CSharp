namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call the method to demonstrate conditional statements
            Conditions();
        }

        public static void Conditions()
        {
            // Declare a variable
            var number = 10;

            // If statements to check different conditions
            if (number >= 10)
            {
                Console.WriteLine("{0} is greater than or equal to 10", number);
            }

            if (number == 10)
            {
                Console.WriteLine("{0} is equal to 10", number);
            }

            if (number <= 10)
            {
                Console.WriteLine("{0} is less than or equal to 10", number);
            }
            else if (number != 10)
            {
                Console.WriteLine("{0} is not equal to 10", number);
            }

            // Using the else statement to handle the alternative case
            if (number >= 10)
            {
                Console.WriteLine("{0} is greater than or equal to 10", number);
            }
            else
            {
                Console.WriteLine("{0} is less than 10", number);
            }

            // Ternary operator to simplify conditional statements
            var result = number == 10 ? "Number is 10" : "Number is not 10";
            Console.WriteLine(result);

            // Logical operators && (and), || (or)
        }
    }
}
