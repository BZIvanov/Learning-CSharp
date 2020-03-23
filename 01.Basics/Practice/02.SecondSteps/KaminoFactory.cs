using System;
using System.Linq;

namespace SecondSteps
{
    class KaminoFactory
    {
        static void Main(string[] args)
        {
            /* Input:
                1!0!1!1!0
                0!1!1!0!0
                Clone them!
            */
            int length = 5;
            string input = Console.ReadLine();
            int[] final = new int[length];
            int finalIndex = 0;
            int index = 0;
            int[] nums = new int[length];

            while (input != "Clone them!")
            {
                index++;
                nums = input.Split(new char[] { '!', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                int[] parameters = GetInfo(nums);

                if(IsBetter(parameters, final))
                {
                    final = nums;
                    finalIndex = index;
                }
                if (finalIndex == 0)
                {
                    final = nums;
                    finalIndex = index;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {finalIndex} with sum: {final.Sum()}.");
            Console.WriteLine(string.Join(" ", final));
        }

        static bool IsBetter(int[] parameters, int[] final)
        {
            int[] finalParameters = GetInfo(final);
            if (parameters[0] > finalParameters[0])
            {
                return true;
            }
            else if (parameters[0] == finalParameters[0])
            {
                if (parameters[1] < finalParameters[1])
                {
                    return true;
                }
                else if (parameters[1] == finalParameters[1])
                {
                    if (parameters[2] > finalParameters[2])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static int[] GetInfo(int[] nums)
        {
            int sequence = 0;
            int position = 0;
            int sum = nums.Sum();
            int counter = 0;
            int counterMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i - counter + 1;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            sequence = counterMax;

            return new int[] { sequence, position, sum };
        }
    }
}
