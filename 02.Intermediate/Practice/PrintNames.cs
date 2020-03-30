using System;
using System.Linq;

namespace IntermediateLevel
{
    class PrintNames
    {
        static void Main(string[] args)
        {
            Action<string> honor = (name) =>
            {
                Console.WriteLine("Sir " + name);
            };

            Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(honor);
        }
    }
}
