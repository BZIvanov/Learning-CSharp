using System;

namespace LearnBasics
{
    // enum have default values which are int and starting from 0, but is best practice to give them some values
    public enum Colors
    {
        Pink = 1,
        Blue = 2,
        Green = 3,
    }
    class Enums
    {
        static void Main(string[] args)
        {
            var color = Colors.Green;
            Console.WriteLine(color);
            Console.WriteLine((int)color);

            // with enum we can use casting which will cast to the specified enum
            int n = 2;
            Console.WriteLine((Colors)n);
        }
    }
}
