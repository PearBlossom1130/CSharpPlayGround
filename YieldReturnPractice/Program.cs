using System;
using System.Collections.Generic;
using System.Linq;

namespace YieldReturnPractice
{
    class Program
    {
        /// <summary>
        /// Populating the list is like downloading the whole video, whereas using yield is like streaming that video
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var returnedNumbers1 = GetNumbersWithYield(10);
            foreach (var i in returnedNumbers1.Skip(2).Take(2))
            {
                Console.WriteLine($"[Yield] Returned  Number: {i}");
            }

            var returnedNumbers2 = GetNumbersWithList(10);
            foreach (var i in returnedNumbers2.Take(3))
            {
                Console.WriteLine($"[List]  Returned  Number: {i}");
            }
        }

        /// <summary>
        /// Return with yield keyword
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        public static IEnumerable<int> GetNumbersWithYield(int maxNumber)
        {
            Console.WriteLine($"[Yield] Input number: {maxNumber}");
            for (int i = 0; i < maxNumber; i++)
            {
                Console.WriteLine($"Returning Number: {i}");
                yield return i;
            }

            yield return 1000;
        }

        public static IEnumerable<int> GetNumbersWithList(int maxNumber)
        {
            Console.WriteLine($"[List] Input number: {maxNumber}");
            var returnedNumbers = new List<int>();
            for (int i = 0; i < maxNumber; i++)
            {
                Console.WriteLine($"Returning Number: {i}");
                returnedNumbers.Add(i);
            }

            return returnedNumbers;
        }
    }
}
