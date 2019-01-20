namespace _15.Neighbour_Wars
{
    using System;
    public class StartUp
    {
        public static void Main()
        {

            int hitPesho = int.Parse(Console.ReadLine());
            int hitGosho = int.Parse(Console.ReadLine());
            if (hitGosho >= 0 && hitPesho >= 0)
            {
                int healthPesho = 100;
                int healthGosho = 100;

                for (int i = 1; i < 100; i++)
                {
                    if (i % 2 == 1)
                    {
                        healthGosho -= hitPesho;
                        if (healthGosho > 0)
                        {
                            Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                        }
                    }
                    else
                    {
                        healthPesho -= hitGosho;
                        if (healthPesho > 0)
                        {
                            Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                        }
                    }

                    if (healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {i}th round.");
                        return;
                    }
                    else if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {i}th round.");
                        return;
                    }
                    if (i % 3 == 0)
                    {
                        healthPesho += 10;
                        healthGosho += 10;
                    }
                }
            }
        }

    }
}

