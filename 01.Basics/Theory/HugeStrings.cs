using System;
using System.Text;

namespace LearnBasics
{
    class HugeStrings
    {
        static void Main()
        {
            // StringBuilder is optimized way for working with a lot of strings, not for searching like index or something else
            var builder = new StringBuilder()
                .Append('*', 5)
                .AppendLine()
                .Append("Hello")
                .AppendLine()
                .Append('*', 5);
            Console.WriteLine(builder);
        }
    }
}
