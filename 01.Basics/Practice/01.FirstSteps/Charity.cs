using System;

namespace FirstSteps
{
    class Charity
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakesIncome = cakes * 45;
            double gofretiIncome = gofreti * 5.8;
            double pancakesIncome = pancakes * 3.2;

            double totalIncomePerDay = (cakesIncome + gofretiIncome + pancakesIncome) * people;
            double incomeWholeCompany = totalIncomePerDay * days;

            double amountAfterExpenses = incomeWholeCompany - (incomeWholeCompany * (1 / 8.0));
            Console.WriteLine($"{amountAfterExpenses:f2}");
        }
    }
}
