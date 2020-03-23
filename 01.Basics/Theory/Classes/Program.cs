using System;
// our Calculator class is in a different namespace and to access it we have to start using that namespace
using LearnBasics.Math;

namespace LearnBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            var qnko = new Person();
            qnko.FirstName = "Qnko";
            qnko.LastName = "Ivanov";
            qnko.Introduce();

            Calculator calc = new Calculator();
            var result = calc.Add(2, 5);
            Console.WriteLine(result);
        }
    }
}
