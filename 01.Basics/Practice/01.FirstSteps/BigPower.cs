using System;
using System.Numerics;

namespace FirstSteps
{
    class BigPower
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger a = 1;

            for (int i = 0; i < n; i++)
            {
                a = a * n;
            }

            Console.WriteLine(a);
        }
    }
}
