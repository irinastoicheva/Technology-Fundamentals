using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int employee = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employee:d8}");
            Console.WriteLine($"Salary: {salary:f2}");
        }
    }
}
