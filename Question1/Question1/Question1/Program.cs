using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Question 1.1 
            List<int> num = new List<int> { 12, 35, 10, 250, 12, 77, 35, 7, 9, 10 };
            Console.WriteLine($"The list of integers: {string.Join(", ", num)}");
            Console.WriteLine();

            // Question 1.2
            double avg = num.Average();
            Console.WriteLine($"The average of all numbers in list of 1.1: {avg} ");
            Console.WriteLine();

            // Question 1.3 and 1.4
            var num2 = num.Where(x => x > 30).OrderBy(x => x).ToList();
            Console.WriteLine($"Numbers that are greater than 30 and in ascending: {string.Join(", ", num2)} ");
            Console.WriteLine();

            // Question 1.5
            var distinctedNums = num.Distinct();
            Console.WriteLine($"Numbers that are not repeated: {string.Join(", ", distinctedNums)}");
            Console.ReadKey();
        }
    }
}
