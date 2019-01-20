using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energy = double.Parse(Console.ReadLine());
            double sugar = double.Parse(Console.ReadLine());

            double totalEnergy = volume * energy / 100;
            double totalSugar = volume * sugar / 100;

            Console.Write($"{volume}ml ");
            Console.WriteLine($"{name}:");
            Console.Write($"{totalEnergy}kcal, ");
            Console.WriteLine($"{totalSugar}g sugars");

        }
    }
}
