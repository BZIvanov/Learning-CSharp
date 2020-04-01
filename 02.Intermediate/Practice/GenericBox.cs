using System;

namespace IntermediateLevel
{
    // it is common practice to name generic with T, but any name would actually work in terms of compiling the code
    public class Box<MyType>
    {
        public Box(MyType value)
        {
            this.Value = value;
        }

        public MyType Value { get; set; }

        public override string ToString()
        {
            return $"{this.Value.GetType()}: {this.Value}";
        }
    }
    class GenericBox 
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                Box<string> box = new Box<string>(value);
                Console.WriteLine(box);
            }
        }
    }
}
