namespace _3.Restaurant_Discount
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine().ToLower();
            double totalCost = 0;
            double pricePerPerson = 0;
            if (groupSize >= 1 && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                totalCost = 2500;
                if (package == "normal")
                {
                    totalCost = (totalCost + 500) * 0.95;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "gold")
                {
                    totalCost = (totalCost + 750) * 0.9;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "platinum")
                {
                    totalCost = (totalCost + 1000) * 0.85;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                totalCost = 5000;
                if (package == "normal")
                {
                    totalCost = (totalCost + 500) * 0.95;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "gold")
                {
                    totalCost = (totalCost + 750) * 0.9;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "platinum")
                {
                    totalCost = (totalCost + 1000) * 0.85;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                totalCost = 7500;
                if (package == "normal")
                {
                    totalCost = (totalCost + 500) * 0.95;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "gold")
                {
                    totalCost = (totalCost + 750) * 0.9;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
                else if (package == "platinum")
                {
                    totalCost = (totalCost + 1000) * 0.85;
                    pricePerPerson = totalCost / groupSize;
                    Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
                }
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
 