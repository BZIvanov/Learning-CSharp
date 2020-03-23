using System;

namespace IntermediateLevel
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        // right before the name of the method is the return type
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = Person.Parse("Pesho");
            person.Introduce("Maria");
        }
    }
}
