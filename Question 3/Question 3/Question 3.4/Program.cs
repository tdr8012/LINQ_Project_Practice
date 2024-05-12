using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            emp2Entities db = new emp2Entities();

            foreach (var dr in db.Employees.ToList())
            {
                Console.WriteLine("Id = {0}; Name = {1}", dr.Id, dr.Name);
                Console.WriteLine("Age = {0}", dr.Age);
                Console.WriteLine("Address = {0}", dr.Address);
                Console.WriteLine("Salary = {0}", dr.Salary);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
