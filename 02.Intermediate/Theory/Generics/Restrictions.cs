using System;

namespace IntermediateLevel
{
    // this way we require T to be of type struct
    public class NumCreator<T> where T : struct
    {
        public static T Create<T>(T item)
        {
            return item;
        }
    }

    class Restrictions 
    {
        static void Main(string[] args)
        {
            // dont forget for <type> right after class name, because we need it on class level
            var num = NumCreator<int>.Create(50);
            Console.WriteLine(num);
        }
    }
}