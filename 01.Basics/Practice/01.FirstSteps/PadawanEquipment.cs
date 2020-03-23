using System;

namespace FirstSteps
{
    class PadawanEquipment
    {
        static void Main()
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int bonusBelts = students / 6;

            double sabresMoney = sabrePrice * Math.Ceiling(students * 1.1);
            double robesMoney = robePrice * students;
            double beltMoney = beltPrice * (students - bonusBelts);

            double totalCost = sabresMoney + robesMoney + beltMoney;

            if (money >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalCost - money:F2}lv more.");
            }
        }
    }
}
