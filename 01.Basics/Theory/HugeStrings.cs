using System;
using System.Text;

namespace LearnBasics
{
    class HugeStrings
    {
        static void Main()
        {
            // StringBuilder is optimized way for working with a lot of strings
            var builder = new StringBuilder()
                .AppendLine()
                .Append("Hello")
                .AppendLine()
                .Append('*', 5);
            Console.WriteLine(builder);
        }
    }
}
