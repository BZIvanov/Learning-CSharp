using System;

namespace IntermediateLevel
{
    public class Person
    {
        // we can define getter and setter like this for shorter syntax
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }

        // we set birthdate in the counstructor, because our set method is private so we can access it only once here
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // for this method we dont have a setter, because we dont need one
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
