using System;

namespace LearnBasics
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("Added a link to" + url);
        }
    }
}
