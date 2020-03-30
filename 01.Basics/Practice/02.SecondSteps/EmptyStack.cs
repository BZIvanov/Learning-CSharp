using System;
using System.Collections.Generic;
using System.Linq;

namespace IntermediateLevel
{
    class EmptyStack
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>();

            // if we use foreach on Stack looping through all elements will not empty it, because foreach is actually creating new collection from the provided one
            foreach (var symbol in input)
            {
                stack.Push(symbol);
            }

            while (stack.Any())
            {
                Console.Write(stack.Pop());
            }
        }
    }
}
