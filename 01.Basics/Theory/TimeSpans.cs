using System;

namespace LearnBasics
{
    class TimeSpans
    {
        static void Main(string[] args)
        {
            var timeSpan = new TimeSpan(2, 3, 5);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(3);
            // the difference between dates is also timespan
            var duration = end - start;
            Console.WriteLine(duration);
        }
    }
}
