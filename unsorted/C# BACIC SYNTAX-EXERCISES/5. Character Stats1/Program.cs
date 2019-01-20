using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Character_Stats1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();
            int health = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int lostHealt = maxHealth - health;
            int energy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            int lostEnergy = maxEnergy - energy;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: |" + new string('|', health) + new string('.', lostHealt) + '|');
            Console.WriteLine("Energy: |" + new string('|', energy) + new string('.', lostEnergy) + '|');
        }
    }
}