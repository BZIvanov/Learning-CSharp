using System;

namespace IntermediateLevel
{
    // delegate allows us to create custom type for method, second is the return type and then the name
    // more often Action and Func are used instead of delegate
    delegate int MyThing(int x, int y);

    class Delegator
    {
        static void Main(string[] args)
        {
            // the type of this variable now is our method, which we can reuse
            MyThing multiplication = MultiplyThem;

            var result = multiplication(5, 5);
            Console.WriteLine(result);
        }

        static int MultiplyThem(int a, int b)
        {
            return a * b;
        }
    }
}
