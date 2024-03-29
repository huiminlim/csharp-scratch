using System;
using System.Collections.Generic;
using System.Linq;

namespace Learning
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            /*
             *  IEnumerable<>
             */

            // String array as a sequence that implements IEnumerable<string>
            string[] names = new[] { "Michael", "Pam", "Jim", "Dwight",
                "Angela", "Kevin", "Toby", "Creed" };

            // Finding a name that ends with 'M'
            // Returns answer in array of strings
            var query1 = names.Where(name => name.EndsWith("m"));
            string[] result1 = query1.ToArray();
            foreach (string name in result1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Finding a name using LINQ query comprehension syntax
            var query2 = from name in names where name.EndsWith("m") select name;
            List<string> result2 = query2.ToList();
            foreach (string name in result2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Defining a custom function to filter Where
            var query3 = names.Where(new Func<string, bool>(NameLongerThanFour));
            foreach (string name in query3)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Similarly defining a custom function for filter
            // using lambdas
            // OrderBy can also be used to sort
            var query4 = names
                .Where(name => name.Length > 4)
                .OrderBy(name => name.Length)
                .ThenBy(name => name);
            foreach (string name in query4)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            /*
             *  Sets and Bags
             */
            string[] cohort1 = new[] { "Rachel", "Gareth", "Jonathan", "George" };
            string[] cohort2 = new[] { "Jack", "Stephen", "Daniel", "Jack", "Jared" };
            string[] cohort3 = new[] { "Declan", "Jack", "Jack", "Jasmine", "Conor" };

            // Converting string array to distinct items (set)
            var distinct = cohort3.Distinct();
            foreach (string name in distinct)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Intersect
            var intersect = cohort3.Intersect(cohort2);
            foreach (string name in intersect)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Except
            var except = cohort2.Except(cohort3);
            foreach (string name in except)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();
        }

        // Function to test if string is length > 3
        // Custom function for filtering
        static bool NameLongerThanFour(string name)
        {
            return name.Length > 3;
        }
    }
}
