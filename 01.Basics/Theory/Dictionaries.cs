using System.Collections.Generic;

namespace LearnBasics
{
    class Dictionaries
    {
        static void Main(string[] args)
        {
            // fill some data upon creation
            Dictionary<string, int> diction = new Dictionary<string, int>
            {
                { "planets", 5 },
                { "stars", 8 }
            };
            diction["oceans"] = 3;

            Dictionary<int, int> dict = new Dictionary<int, int>();
            dict.Add(1, 5);
        }
    }
}