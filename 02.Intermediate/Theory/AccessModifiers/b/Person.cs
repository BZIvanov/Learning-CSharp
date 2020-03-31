using System;

namespace IntermediateLevel
{
    public class Person
    {
        // private set means, that we can only set the value in the constructor or another method.
        public DateTime Birthdate { get; private set; }

        // we set birthdate in the counstructor, because our set method is private so we can access it only once here
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        // for this method we dont have a setter, because we dont need one. If we have only get and not set, only the constructor can set value for this property
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
