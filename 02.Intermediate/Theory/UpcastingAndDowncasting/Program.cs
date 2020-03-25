using System;

namespace IntermediateLevel
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
        }
    }

    public class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // here text and shape variables are referencing to the same object, but they have different views, meaning access to fields and methods. For example shape will not have access to text specific methods because it is the parent class
            Text text = new Text();
            // example of upcasting with no conversion required
            Shape shape = text;

            // Upcasting
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); // 100

            // Downcasting
            // after casting to Text we now have all properties in tx variable based on sh variable
            Shape sh = new Text();
            Text tx = (Text)sh;
        }
    }
}
