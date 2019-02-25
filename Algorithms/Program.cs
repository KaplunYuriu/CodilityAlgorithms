using System;
using System.Linq;
using Algorithms.Arrays;
using Algorithms.Iterations;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Gap");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(BinaryGap.FindBinaryGaps(529).OrderByDescending(x => x).First());
            Console.WriteLine("--------------------------------------");


            Console.WriteLine("Odd Occurrences In Array");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(OddOccurrencesInArray.FindOddNumber(new[] {9,3, 9, 3, 9, 7, 9}));
            Console.WriteLine("--------------------------------------");

            Console.WriteLine("Cyclic Rotation");
            Console.WriteLine("--------------------------------------");
            var rotated = CyclicRotation.Rotate(new[] {3, 8, 9, 7, 6}, 3);
            Console.WriteLine(string.Join(",", rotated));
            Console.WriteLine("--------------------------------------");

            Console.ReadLine();
        }
    }
}
