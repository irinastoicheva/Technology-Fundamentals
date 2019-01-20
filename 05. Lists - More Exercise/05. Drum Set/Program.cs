namespace _05._Drum_Set
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> drums = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> drumsCopyStarted = new List<int>(drums);
            string command = Console.ReadLine();
            while (command != "Hit it again, Gabsy!")
            {
                int power = int.Parse(command);

                for (int i = 0; i < drums.Count; i++)
                {
                    drums[i] -= power;
                    if (drums[i] <= 0)
                    {
                        int priceNewDrum = drumsCopyStarted[i] * 3;
                        if (savings >= priceNewDrum)
                        {
                            savings -= priceNewDrum;
                            drums[i] = drumsCopyStarted[i];
                        }
                        else
                        {
                            drums.RemoveAt(i);
                            drumsCopyStarted.RemoveAt(i);
                            i--;
                        }
                        
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", drums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
