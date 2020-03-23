using System;

namespace IntermediateLevel
{
    public class Person
    {
        // private fields can not be accessed outside of the class. By convention we prefix with underscore
        private DateTime _birthdate;

        // we manipulate private fields with setters
        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        // we expose private fields with getters
        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
	class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1993, 5, 7));
            Console.WriteLine(person.GetBirthdate());
		}
    }
}
