using System;
using System.Collections.Generic;

namespace LearnBasics
{
    class Sets
    {
        static void Main(string[] args)
        {
            // set keeps only unique values
            HashSet<int> nums = new HashSet<int>();
            nums.Add(1);
            nums.Add(1);
            nums.Add(4);
            nums.Add(5);

            Console.WriteLine(nums.Count); // 3
        }
    }
}
