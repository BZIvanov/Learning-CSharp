using System;

namespace LearnBasics
{
    class Casting
    {
        static void Main(string[] args)
        {
           // this is how we cast explicitly to another type
            int a = 100;
            byte b = (byte) a;
            Console.WriteLine(b);

            // this is how we convert with Convert method, because here we have incompatible types of number and text
            string nums = "279";
            int myValue = Convert.ToInt32(nums);
            Console.WriteLine(myValue);

            // here we first have ints, but we expect real number so we need to cast, otherwise we will get 3 as result
            var x = 10;
            var y = 3;
            Console.WriteLine((float) x / (float) y);
        }
    }
}
