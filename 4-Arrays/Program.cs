
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single-dimensional array declaration with a specified size
            string[] students = new string[3];

            // Another way to declare and initialize an array
            string[] students2 = new[] { "1", "2" };

            // Yet another way to declare and initialize an array
            string[] students3 = { "1", "2" };

            // Loop through and print the elements of the array using foreach
            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            // Multidimensional array declaration and initialization
            string[,] region = new string[7, 3]
            {
                {"1", "1", "1"},
                {"2", "2", "2"},
                {"3", "3", "3"},
                {"4", "4", "4"},
                {"5", "5", "5"},
                {"6", "6", "6"},
                {"7", "7", "7"},
            };

            // Loop through and print the elements of the multidimensional array using nested loops
            for (int i = 0; i <= region.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= region.GetUpperBound(1); j++)
                {
                    Console.WriteLine(region[i, j]);
                }
            }
        }
    }
}
