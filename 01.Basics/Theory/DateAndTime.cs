using System;

namespace LearnBasics
{
    class DateAndTime
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Hour " + now.Hour);
            Console.WriteLine(now.ToString("yyyy"));
        }
    }
}
