
namespace _07._Vending_Machine
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine().ToLower();
            decimal totalMoney = 0M;
            decimal money = 0M;
            string hh = command;

            while (command != "start")
            {
                try
                {
                    money = decimal.Parse(command);
                    if (money == 0.10M || money == 0.2M || money == 0.5M || money == 1 || money == 2)
                    {
                        totalMoney += money;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {money}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine($"Cannot accept {hh}");
                }
                
                command = Console.ReadLine().ToLower();
            }
            string command1 = Console.ReadLine().ToLower();
            while (command == "start")
            {
                if (command1 == "nuts")
                {
                    if (totalMoney - 2.0M >= 0)
                    {
                        Console.WriteLine($"Purchased {command1}");
                        totalMoney -= 2.0M;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command1 == "water")
                {
                    if (totalMoney - 0.7M >= 0)
                    {
                        Console.WriteLine($"Purchased {command1}");
                        totalMoney -= 0.7M;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command1 == "crisps")
                {
                    if (totalMoney - 1.5M >= 0)
                    {
                        Console.WriteLine($"Purchased {command1}");
                        totalMoney -= 1.5M;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command1 == "soda")
                {
                    if (totalMoney - 0.8M >= 0)
                    {
                        Console.WriteLine($"Purchased {command1}");
                        totalMoney -= 0.8M;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command1 == "coke")
                {
                    if (totalMoney - 1 >= 0)
                    {
                        Console.WriteLine($"Purchased {command1}");
                        totalMoney -= 1;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (command1 == "end")
                {
                    Console.WriteLine($"Change: {totalMoney:F2}");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command1 = Console.ReadLine().ToLower();
            }
        }
    }
}
