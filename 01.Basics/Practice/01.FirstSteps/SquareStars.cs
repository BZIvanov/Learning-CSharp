using System;

namespace FirstSteps
{
    class SquareStars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new String('*', n));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine($"*{new String(' ', n - 2)}*");
            }
            Console.WriteLine(new String('*', n));
        }
    }
}
