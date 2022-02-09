using System;
using System.Collections.Generic;

namespace Utopian_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var periods1 = new List<int>()
                    {
                        0,
                        1,
                        4,
                    };

            var periods2 = new List<int>()
                    {
                        6,
                        5,
                        4,
                    };

            Console.WriteLine("Example 1:");
            var heights1 = HeightCalculation(periods1);
            PrintResult(periods1, heights1);
            Console.WriteLine();

            Console.WriteLine("Example 2:");
            var heights2 = HeightCalculation(periods2);
            PrintResult(periods2, heights2);
            Console.WriteLine();
        }

        public static List<int> HeightCalculation(List<int> periods)
        {

            
            var heights = new List<int>();
            foreach(var period in periods)
            {
                var height = 1;
                for (var i = 1; i <= period; i++)
                {

                    if ((i % 2) == 0)
                        height++;
                    else
                        height *= 2;

                }

                heights.Add(height);
            }           
            return heights;
        }

        public static void PrintResult(List<int> periods, List<int> heights)
        {
            Console.WriteLine("Period - Height");
            for (var i = 0; i < periods.Count; i++)
            {
                Console.WriteLine("  " + periods[i] + "    -   " + heights[i]);
            }
        }
    }
}
