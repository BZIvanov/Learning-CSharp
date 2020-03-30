using System;
using System.Collections.Generic;

namespace LearnBasics
{
    class Stacks
    {
        static void Main(string[] args)
        {
            var myStack = new Stack<string>();
            // adds new element on the top of the stack
            myStack.Push("First");
            myStack.Push("Second");

            // here we will have the top element of our stack and that element will no longer exist on the stack
            var result = myStack.Pop();

            // peek will return the mosttop element, but will not remove it from the stack
            var checkIt = myStack.Peek();

            Console.WriteLine(checkIt); // First
        }
    }
}
