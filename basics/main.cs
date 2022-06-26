// Namespaces are imported to tell compiler the 
// location to look for the methods
using System;

namespace Basic
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            // Strings
            string s1 = "Bob\tSmith";
            string s2 = "Bob\\tSmith";
            string s3 = @"Bob\\tSmith";
            Console.WriteLine($"{s1} vs {s2} vs {s3}");

            // String print formatting using positional arguments
            Console.WriteLine(
                format: "{0} apples costs {1:C}",
                arg0: 12,
                arg1: 0.35);
            string s4 = $"{s1} {s2}";
            Console.WriteLine($"{s4}");

            // Numbers
            int dec = 2_000_000;
            int binary = 0b_0001_1110_1000_0100_1000_0000;
            int hex = 0x_001E_8480;
            Console.WriteLine($"Hex == bin == dec: {dec == binary && dec == hex}");
            // :N0 represents decimal separator
            Console.WriteLine($"Int max, min: {int.MaxValue:N0}, {int.MinValue}");

            // Casting numbers
            double t1 = 1.23;
            int t2 = (int)t1;
            int t3 = Convert.ToInt32(t2);
            Console.WriteLine($"{t1} casted to {t2} / {t3}");

            // Object
            object name = "Bob";
            object height = 1.54;
            float height2 = Convert.ToSingle(height);  // to convert object to float 
            Console.WriteLine($"{name} is {height2} m tall");

            // Dynamic types
            dynamic x = "Hello";
            x = 12;
            x = new[] { 1, 2, 3 };
            Console.WriteLine($"Dynamic type containing array x: {x.Length}");

            // Exception
            try
            {
                int age = int.Parse("hello");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}: {ex.Message}");
            }
        }
    }
}