using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new DateTime(1993, 5, 7));
            Console.WriteLine(person.Age);
		}
    }
}
