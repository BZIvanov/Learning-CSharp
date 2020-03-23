using System;

namespace LearnBasics
{
    class TypesAndPlaceholder
    {
        static void Main(string[] args)
        {
            // We can declare variables and assign them value later
            int repeats;
            // or we can assign values right after declaring
            int people = 5;
            // With const keyword we make sure the value will never change. Pascal case is recommended
            const int DaysOfWeek = 7;
            // double is default for floating numbers so in this case we have to postfix *f* to make sure both sides of the equal sign are of same type
            float hours = 1.5f;
            // same goes with decimal
            decimal miles = 2.35m;

            repeats = 7;
            // this is how we use placeholders
            Console.WriteLine("Do {0} exercises for each {1} people.", repeats * DaysOfWeek, people);
            Console.WriteLine("{0} and {1}", int.MinValue, int.MaxValue);
        }
    }
}
