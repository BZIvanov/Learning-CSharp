using System;

namespace FirstSteps
{
    class CurrencyConverter
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string output = Console.ReadLine();

            double levValue = 1d;
            switch (input)
            {
                case "BGN": levValue = value * 1; break;
                case "USD": levValue = value * 1.79549; break;
                case "EUR": levValue = value * 1.95583; break;
                case "GBP": levValue = value * 2.53405; break;
                default: Console.WriteLine("error"); break;
            }

            double result = 0d;
            switch (output)
            {
                case "BGN": result = levValue; break;
                case "USD": result = levValue / 1.79549; break;
                case "EUR": result = levValue / 1.95583; break;
                case "GBP": result = levValue / 2.53405; break;
                default: Console.WriteLine("error"); break;
            }

            Console.WriteLine(Math.Round(result, 2) + " BGN");
        }
    }
}
