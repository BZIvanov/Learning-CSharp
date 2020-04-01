using System;

namespace IntermediateLevel
{
    public class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst firstItem, TSecond secondItem)
        {
            this.FirstItem = firstItem;
            this.SecondItem = secondItem;
        }

        public TFirst FirstItem { get; set; }
        public TSecond SecondItem { get; set; }

        public override string ToString()
        {
            return $"{this.FirstItem} -> {this.SecondItem}";
        }
    }
    class GenericTuple 
    {
        static void Main(string[] args)
        {
            /* Input
            Ina Ivanova Bankq
            Ariana 5
            34 23.457
            */
            var personInfo = Console.ReadLine().Split();
            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = personInfo[2];

            var nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int beerAmount = int.Parse(nameAndBeer[1]);

            var thirdInput = Console.ReadLine().Split();
            int firstArgument = int.Parse(thirdInput[0]);
            double secondArgument = double.Parse(thirdInput[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, address);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beerAmount);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(firstArgument, secondArgument);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
