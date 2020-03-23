using System;

namespace FirstSteps
{
    class TimePlusFifteen
    {
        static void Main()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalTimeMinutesPlusFifteen = hours * 60 + minutes + 15;
            
            int h = totalTimeMinutesPlusFifteen / 60;
            int m = totalTimeMinutesPlusFifteen % 60;
            if (h >= 24)
            {
                h -= 24;
            }

            Console.WriteLine($"{h}:{m:D2}");
        }
    }
}
