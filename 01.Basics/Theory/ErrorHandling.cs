using System;

namespace LearnBasics
{
    class ErrorHandling
    {
        static void Main(string[] args)
        {
			try
			{
				// here we will get error, but we don't want our application to crash so we handle it this way
				var number = "1234";
				byte b = Convert.ToByte(number);
				Console.WriteLine(b);
			}
			catch (Exception)
			{
				Console.WriteLine("The number is too large to be converted to byte");
			}
        }
    }
}
