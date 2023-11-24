using System;

namespace Exceptions
{
    class Exceptions
    {
        public static void Main(string[] args)
        {
            // ExceptionIntro(); // This line is commented out and currently inactive.
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[2] { "Engin", "Serkan" };
                students[2] = "Serkan"; // Exceeding array bounds, hence an IndexOutOfRangeException will be thrown.
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException"); // When an error of type IndexOutOfRangeException is caught, this message is displayed (custom message).
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message); // When a general Exception type error is caught, the message of the error is displayed (generic message).
            }
        }
    }
}
