using System;
using System.Linq;

namespace IntermediateLevel
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            // test input: 2 5 8 9 12 1
            Func<int[], int> minFunc = (arr) =>
            {
                int minValue = int.MaxValue;
                foreach (var num in arr)
                {
                    if (num < minValue)
                    {
                        minValue = num;
                    }
                }
                return minValue;
            };

            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(minFunc(arr));
        }
    }
}
