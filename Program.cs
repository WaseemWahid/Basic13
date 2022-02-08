using System;
using System.Collections.Generic;

namespace Basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = new int[]
            {
                0, 10, 15, 20, -10, -5
            };
            int[] secondArr = new int[] 
            {
                -5,-4,-3,-2,-1, 2
            };
            // object[] objArr = Exercises.LoopArray(testArray);
            Exercises.PrintNumbers();
            Exercises.PrintOdds();
            Exercises.PrintSum();
            Exercises.FindMax(testArray);
            int[] odds = Exercises.OddArray();
            Exercises.GetAverage(testArray);
            Exercises.GreaterThanY(testArray, 12);
            Exercises.SquareArrayValues(testArray);
            Exercises.EliminateNegatives(testArray);
            Exercises.MinMaxAverage(testArray);
            Exercises.ShiftArrayValues(testArray);
            object[] objArr = Exercises.NumToString(secondArr);
        }
    }
}
