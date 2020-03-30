using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            // the last item in the diamond brackets is for the return type of the method, the others before that are parameters of the method
            Func<int, int, int> myThing = MultiplyThem;

            Console.WriteLine(myThing(2, 5)); // 10
        }

        static int MultiplyThem(int a, int b)
        {
            return a * b;
        }
    }
}
