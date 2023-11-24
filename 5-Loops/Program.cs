namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call different loop methods
            ForLoops();

            WhileLoops();

            ForEachLoops();
        }

        private static void ForEachLoops()
        {
            // Using a foreach loop to iterate over elements in an array
            foreach (var item in new string[] { "1", "2", "3" })
            {
                Console.WriteLine(item);
            }
        }

        private static void WhileLoops()
        {
            // Using a while loop with a condition
            int number = 10;
            while (number < 100)
            {
                number += 1;
            }
        }

        private static void ForLoops()
        {
            // Using a for loop to iterate from 0 to 99
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
