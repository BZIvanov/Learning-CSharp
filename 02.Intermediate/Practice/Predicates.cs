using System;
using System.Collections.Generic;
using System.Linq;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            /* input
                1 10
                odd
            */
            int[] bounds = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string query = Console.ReadLine();

            // function which accepts parameters and returns boolean is predicate
            Predicate<int> predicate = query == "odd" ?
                new Predicate<int>((n) => n % 2 != 0) :
                new Predicate<int>((n) => n % 2 == 0);

            List<int> result = new List<int>();

            for (int i = bounds[0]; i <= bounds[1]; i++)
            {
                if (predicate(i))
                {
                    result.Add(i);
                }
            }

            Console.WriteLine(String.Join(' ', result));
        }
    }
}
