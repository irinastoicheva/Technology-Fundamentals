namespace _05._SoftUni_Parking
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> list = new Dictionary<string, string>();
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                string name = input[1];
                switch (command)
                {
                    case "register":
                        string carNumber = input[2];
                        if (list.ContainsKey(name))
                        {
                            string registedCarnumber = list[name];
                            Console.WriteLine($"ERROR: already registered with plate number {registedCarnumber}");
                        }
                        else
                        {
                            list.Add(name, carNumber);
                            Console.WriteLine($"{name} registered {carNumber} successfully");
                        }
                        break;

                    case "unregister":
                        if (!list.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{name} unregistered successfully");
                            list.Remove(name);
                        }
                        break;
                }
            }
            foreach (var kvp in list)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
