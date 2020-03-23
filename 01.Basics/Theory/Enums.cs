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
            Console.WriteLine(color);  // Green
            Console.WriteLine((int)color);  // 3

            // with enum we can use casting which will cast to the specified enum
            // this way if we receive number we can turn it to our desired text value
            int n = 2;
            Console.WriteLine((Colors)n);  // Blue

            // while typing the Enum.Parse code we see Type, when we see that we can use typeof on it
            // this way if we receive text value we can turn it to our desired number value
            var dressColor = "Pink";
            var myPick = (int) Enum.Parse(typeof(Colors), dressColor);
            Console.WriteLine(myPick);
        }
    }
}
