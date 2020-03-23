using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondSteps
{
    class LargestElements
    {
        static void Main()
        {
            string input = "5 3 4 1";
            List<int> numbers = input.Split(' ').Select(int.Parse).ToList();
            int n = 3;

            numbers.Sort();
            numbers.Reverse();

            Console.WriteLine(String.Join(" ", numbers.GetRange(0, n)));
        }
    }
}
