using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "some text";
            int result = 0;

            // this is a way with 'out' to get the result value without our logic to crash
            // this way if we have value we will get it, otherwise we can handle it in a way we want without working with exceptions
            var parsed = int.TryParse(text, out result);

            if  (parsed)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
