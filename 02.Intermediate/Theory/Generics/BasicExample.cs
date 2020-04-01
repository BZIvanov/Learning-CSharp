using System;
using System.Collections.Generic;

namespace IntermediateLevel
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            var arr = new T[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }

    public class AnotherArrayCreator<T>
    {
        // we are not required to use only one and the same type for class and method, they could be 2 different
        public static T[] Create(int length, T item)
        {
            var arr = new T[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = item;
            }
            return arr;
        }
    }
    class BasicExample 
    {
        static void Main(string[] args)
        {
            // here we will automatically get int array because c# can see that we provided number, this is because the generic is on the method
            var arr = ArrayCreator.Create(10, 100);

            // if the generic is on the class we must specify the type explicitly
            var anotherArr = AnotherArrayCreator<int>.Create(10, 100);
        }
    }
}
