using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 12, 35, 10, 250, 12, -77, 35, 7, 9, 10 };
            int[] array2 = { 12, -5, 250, 17, 12, -5, 250, 35, 10 };


            Func<int[], int> minNumInArray = (array) =>
            {
                int maxNum = array.Min();
                return Array.IndexOf(array, maxNum);
            };

            int o = minNumInArray(array1);
            int j = minNumInArray(array2);

            Console.WriteLine($"The index of the smallest element in array1: {o}");
            Console.WriteLine();
            Console.WriteLine($"The index of the smallest element in array2: {j}");


            Console.ReadKey();
        }
    }
}
