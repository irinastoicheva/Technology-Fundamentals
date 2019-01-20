using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = int.Parse(Console.ReadLine());
            int numberB = int.Parse(Console.ReadLine());
            int sum = numberA + numberB;
            Console.WriteLine($"{numberA} + {numberB} = {sum}");
        }
    }
}
