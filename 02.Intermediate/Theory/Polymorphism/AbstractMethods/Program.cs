using System;

namespace IntermediateLevel
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        // abstract methods dont have bodies
        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copied");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();
        }
    }
}
