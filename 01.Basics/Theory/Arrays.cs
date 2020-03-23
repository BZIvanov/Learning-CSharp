using System;

namespace LearnBasics
{
    class Arrays
    {
        static void Main(string[] args)
        {
            // this way we fill values right after creating the array
            int[] points = new int[3] { 3, 4, 5 };
            // this way we create array with 2 elements
            int[] nums = new int[2];
            nums[0] = 1;

            // another way of creating array is. var can see on the right so no need to specify int or length
            var numbers = new[] { 1, 2, 3, 4, 5 };

            //example of an array method - IndexOf
            var index = Array.IndexOf(numbers, 3);
            Console.WriteLine("Correct index will be 2 :" + index);
        }
    }
}
