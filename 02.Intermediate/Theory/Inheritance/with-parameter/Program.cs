using System;

namespace IntermediateLevel
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized.");
        }
    }

    public class Car : Vehicle
    {
        /*
         for the base class we dont have parameterless constructor
         with the base keyword we can call parent constructor and provide the parameter
        */
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // first the parent constructor will be called
            var car = new Car("ca1234ba");
        }
    }
}
