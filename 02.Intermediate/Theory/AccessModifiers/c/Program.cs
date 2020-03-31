using System;

namespace IntermediateLevel
{
    public class Cat
    {
        // syntax for Age is shorthand syntax so we dont have to write all the code as we write for Name, but under the hood it does the same
        // but in this case we cant have custom logic for get and set, in that case we have to do as we did for Name property
        public int Age { get; set; }

        private string name;
        public string Name
        {
            get
            {
                // pay attention that Name (with capital letter) have get and set which modify name (small letters). So we use Name only to work with name and have name private
                return this.name;
            }
            set
            {
                // value here is a keyword, where we receive whatever we provide, in this example "Ivan"
                if (value == null)
                {
                    return;
                }
                this.name = value;
            }
        }
    }
    class Program 
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            cat.Name = "Ivan";
            cat.Age = 5;
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);
        }
    }
}
