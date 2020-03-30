using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // with Action we can create type for one method and to provide that method as parameter to another method
            // Action is used for void methods, checkout Func for methods with parameters
            Action<int, int> myAction = MultiplyThem;

            Action<string> logger = Console.WriteLine;
        }

        static void MultiplyThem(int a, int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
