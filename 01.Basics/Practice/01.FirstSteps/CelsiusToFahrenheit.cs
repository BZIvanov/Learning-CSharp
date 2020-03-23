using System;

namespace FirstSteps
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            float c = float.Parse(Console.ReadLine());
            float f = c * 1.8f + 32;
            Console.WriteLine(f);
        }
    }
}
