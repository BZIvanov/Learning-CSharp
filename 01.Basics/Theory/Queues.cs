using System;
using System.Collections.Generic;

namespace LearnBasics
{
    class Queues
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            // numbers will be put last on the queue
            numbers.Enqueue(2);
            numbers.Enqueue(5);
            numbers.Enqueue(9);

            Console.WriteLine(numbers.Peek()); // 2
            Console.WriteLine(numbers.Count); // 3
            Console.WriteLine(numbers.Dequeue()); // 2
        }
    }
}
