using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        /*
         * Reflection signifies the ability of a program to examine and modify its own structure at runtime. 
         * In the C# language, Reflection is implemented using the classes under the System.Reflection namespace.
         * Reflection provides convenience in various scenarios, as listed below:
         * 
         * 1. **Working with Non-structural Data:** If the structure of data is not known beforehand or can change (such as XML, JSON), Reflection enables access to such data.
         * 
         * 2. **Inspecting System and User-Defined Types:** During runtime, you can use Reflection to inspect classes and methods in, for example, a DLL file.
         * 
         * 3. **Generic Libraries and Extensions:** When writing a generic library or extension, Reflection can be used to allow users to add their own code.
         * 
         * 4. **Application Loading and Configuration:** Reflection can be used to dynamically load specific types or components during application loading.
         * 
         * However, Reflection can be costly in terms of performance and may raise security concerns, so it should be used carefully.
         */

        static void Main(string[] args)
        {
            // Get the type of the DortIslem class
            Type type = typeof(DortIslem);

            // Create an instance of the DortIslem class using Activator.CreateInstance
            DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 5, 3);

            // Invoke the Topla method of the DortIslem class using reflection
            int sonucTopla = (int)type.GetMethod("Topla").Invoke(dortIslem, new object[] { 7, 2 });

            // Invoke the Carp method of the DortIslem class using reflection
            int sonucCarp = (int)type.GetMethod("Carp").Invoke(dortIslem, new object[] { 4, 6 });

            // Print the results to the console
            Console.WriteLine("Toplama Sonucu: " + sonucTopla);
            Console.WriteLine("Çarpma Sonucu: " + sonucCarp);
        }
    }

    // Sample class DortIslem
    public class DortIslem
    {
        private int _sayi1;
        private int _sayi2;

        // Constructor
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }

        // Addition method
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        // Multiplication method
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
