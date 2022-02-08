using System;
using System.Collections.Generic;

namespace Basic13
{
    public class Exercises
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void PrintOdds()
        {
            for (int i = 1; i <= 255; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 0; i <= 255; i++)
            {
                sum += i;
                Console.WriteLine($"New number: {i} Sum: {sum}" );
            } 
        }
        public static void LoopArray(object[] arr)
        {
            foreach(var x in arr)
            {
                Console.WriteLine(x);
            }
        }
        public static int FindMax(int[] numbers)
        {
            int max = Int32.MinValue;
            foreach(int num in numbers)
            {
                if(max < num)
                    max = num;
            }
            Console.WriteLine($"Max is {max}");
            return max;
        }
        public static float GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
                sum += num;
            float avg = (float)sum / numbers.Length;
            Console.WriteLine($"average is {avg}");
            return avg;
        }
        public static int[] OddArray()
        {
            int size = (255/2) + 1;
            int[] odds = new int[size];
            int i = 0;
            for(int num =1; num <= 255; num+=2)
            {
                odds[i] = num;
                i++;
            }
            return odds;
        }
        public static int GreaterThanY(int[] numbers, int y)
        {
            int total = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > y)
                    total++;
            }
            Console.WriteLine(total);
            return total;
        }
        public static void SquareArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i] * numbers[i];
            }
        }
        public static void EliminateNegatives(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                    numbers[i] = 0;
            }
        }
        public static void MinMaxAverage(int[] numbers)
        {
            int currMin = Int32.MaxValue,
                currMax = Int32.MinValue,
                sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
                if(currMax < num)
                    currMax = num;
                if(currMin > num)
                    currMin = num;
            }
            Console.WriteLine($"Min: {currMin}");
            Console.WriteLine($"max: {currMax}");
            Console.WriteLine($"average: {(float)sum / numbers.Length}");
        }
        public static void ShiftArrayValues(int[] numbers)
        {
            for(int i = 0; i < numbers.Length -1; i++)
            {
                numbers[i] = numbers[i+1];
            }
            numbers[numbers.Length - 1] = 0;
        }
        public static object[] NumToString(int[] numbers)
        {
            object[] newArr = new object[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] < 0)
                    newArr[i] = "Dojo";
                else 
                    newArr[i] = numbers[i];
            }
            return newArr;
        }
    }
}