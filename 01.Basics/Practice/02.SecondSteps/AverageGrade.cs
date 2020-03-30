using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondSteps
{
    class AverageGrade
    {
        static void Main(string[] args)
        {
            /*
5
Ivan 5.20
Maria 6.00
Ivan 5.50
Moni 5.75
Ina 4.75
            */
            var grades = new Dictionary<string, List<double>>();
            int students = int.Parse(Console.ReadLine());

            for (int i = 0; i < students; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string name = inputInfo[0];
                double grade = double.Parse(inputInfo[1]);

                // make sure the List will be existing at the point we will add to it
                if (!grades.ContainsKey(name))
                {
                    grades.Add(name, new List<double>());
                }
                grades[name].Add(grade);
            }

            foreach (var (nameKey, gradeValues) in grades)
            {
                Console.Write($"{nameKey} -> ");
                foreach (var gradeValue in gradeValues)
                {
                    Console.Write($"{gradeValue:F2} ");
                }
                Console.WriteLine($"(avg: {gradeValues.Average():F2})");
            }
        }
    }
}
