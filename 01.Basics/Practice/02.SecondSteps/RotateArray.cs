using System;
using System.Linq;

namespace SecondSteps
{
    class RotateArray
    {
        static void Main()
        {
            string a = "a b c d e";
            string[] arr = a.Split(' ').ToArray();
            string[] result = new string[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = arr[i - 1];
            }

            result[0] = arr[arr.Length - 1];

            Console.WriteLine(String.Join(" ", result));
        }
    }
}
