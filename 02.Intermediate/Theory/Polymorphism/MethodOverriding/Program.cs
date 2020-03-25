using System;
using System.Collections.Generic;

namespace IntermediateLevel
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // here we can write any code specific to this class
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // here we can write any code specific to this class
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Position
    {

    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        // virtual will make this method overridable in derived classes
        public virtual void Draw()
        {

        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // to observe the overall behaviour put breakpoint anywhere and debug
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);
        }
    }
}
