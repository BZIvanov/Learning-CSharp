using System;

namespace FirstSteps
{
    class PokeMon
    {
        static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            sbyte exhaustion = sbyte.Parse(Console.ReadLine());

            int counter = 0;
            int currentPower = power;

            while (currentPower >= distance)
            {
                currentPower -= distance;
                counter++;

                if ((power / 2.0 == currentPower) && (exhaustion != 0))
                {
                    currentPower /= exhaustion;
                }
            }
            Console.WriteLine(currentPower);
            Console.WriteLine(counter);
        }
    }
}
