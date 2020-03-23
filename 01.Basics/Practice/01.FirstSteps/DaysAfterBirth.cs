using System;

namespace FirstSteps
{
    class DaysAfterBirth
    {
        static void Main()
        {
            string date = Console.ReadLine();
            string stringFormat = "dd-MM-yyyy";
            DateTime birthday = DateTime.ParseExact(date, stringFormat, null);
            Console.WriteLine(birthday.AddDays(999).ToString("dd-MM-yyyy"));
        }
    }
}
