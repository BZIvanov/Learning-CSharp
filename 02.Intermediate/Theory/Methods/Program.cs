using System;

namespace IntermediateLevel
{
    class Program
    {
        static void Main(string[] args)
        {
            UseParams();
            UsePoints();
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            // because of params keyword in Add method we can provide random number of parameters and they will be all put into the numbers array
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(new Point(29, 47));
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured!");
            }
        }
    }
}
