using System;

namespace LearnBasics
{
    class Matrix
    {
        static void Main()
        {
            // this is how we will the matrix at the moment of creating it
            var matrix = new int[2, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 0 }
            };
            // this matrix will be filled with 0's
            var another = new int[3, 4];
            // will result in 7
            var cell = matrix[1, 1];

            // Jagged array - non-rectangular
            var jArray = new int[2][];
        }
    }
}