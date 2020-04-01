using System;
using System.Collections;
using System.Collections.Generic;

namespace IntermediateLevel
{
    public class Lake : IEnumerable<int>
    {
        private readonly int[] stones;

        public Lake(params int[] stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < stones.Length; i+=2)
            {
                yield return this.stones[i];
            }
            for (int i = stones.Length - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

    class StoneEnumerators 
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
