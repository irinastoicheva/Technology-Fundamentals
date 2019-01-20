using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal width = decimal.Parse(Console.ReadLine());
            decimal height = decimal.Parse(Console.ReadLine());
            decimal area = width * height;
            Console.WriteLine($"{area:F2}");
        }
    }
}
