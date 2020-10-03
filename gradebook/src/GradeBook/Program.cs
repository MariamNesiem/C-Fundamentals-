using System;
using System.Collections.Generic;
namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3.5;
            double y = 1.5;
            var result = x + y;
            Console.WriteLine($"Variable: {result}");

            //arrays
            double[] number = new double[2];
            number[0] = 1;
            number[1] = 2;
            Console.WriteLine($"Array 1: {number[0]}");

            double[] numbers = new double[] { 1, 2, 3, 4 };
            Console.WriteLine($"Array 2: {numbers[1]}");

            //loop
            var array = new[] { 1, 2, 3, 4, 5 };
            var sum = 0;
            foreach (var a in array)
            {
                sum += a;
            }
            var avg = sum / array.Length;
            Console.WriteLine($"Sum of array: {sum}");
            Console.WriteLine($"Avg of array: {avg}");

            //list
            List<int> grade = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var grades = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            grades.Add(10);
            var highgrade=double.MinValue;
            var lowgrade=double.MaxValue;


            var sum2 = 0;
            foreach (var a in grades)
            {
                highgrade=Math.Max(a,highgrade);
                lowgrade=Math.Min(a,lowgrade);
                sum2 += a;
            }
            var avg2 = sum2 / grades.Count;
            Console.WriteLine($"Sum of list: {sum2}");
            Console.WriteLine($"Avg of list: {avg2}");
            Console.WriteLine($"Max of list: {highgrade}");
            Console.WriteLine($"Min of list: {lowgrade}");

            //use args parameter
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine($"Hello!");
            }

        }
    }
}
