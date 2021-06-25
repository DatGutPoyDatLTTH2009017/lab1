using System;
using System.Collections.Generic;

namespace lap8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int>temperatures = new List<int>();
            temperatures.Add(1);
            temperatures.Add(200);
            temperatures.Add(15);
            temperatures.Add(50);
            temperatures.Add(120);
            temperatures.Add(10);
            int result = 0;
            foreach (int n in temperatures)
            {
                if (n >= 25)
                {
                    result = result + 1;
                }
            }
            Console.WriteLine("Number of temperatures >= 25 degrees: {0}", result);

            int result2 = GreaterCount(temperatures, 25);
            Console.WriteLine("Number of elements of the list >= min: {0}", result2);
        }

        public static int GreaterCount(List<int> list, double min)
        {
            int result = 0;
            foreach (int n in list)
            {
                if (n >= min)
                {
                    result = result + 1;
                }
            }
            return result;
        }
    }
}