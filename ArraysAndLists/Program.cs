using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();

            var odds = new List<int>();

            foreach (int num in intArray)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
                else
                {
                    odds.Add(num);
                }
            }

            Console.WriteLine("Evens");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("");
            Console.WriteLine("Odds");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
        }
    }
}
