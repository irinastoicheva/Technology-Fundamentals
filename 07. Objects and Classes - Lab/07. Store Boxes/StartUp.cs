namespace _07._Store_Boxes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Box
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; } 
        public double Price { get; set; } 
        public double TotalPrice { get; set; } 
    }
    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            List<Box> boxs = new List<Box>();
            while (command != "end")
            {
                string[] input = command.Split().ToArray();
                string serialNumber = input[0];
                string name = input[1];
                int quantity = int.Parse(input[2]);
                double price = double.Parse(input[3]);
                double totalPrice = quantity * price;

                Box currentBox = new Box
                {
                    SerialNumber = serialNumber,
                    Name = name,
                    Quantity = quantity,
                    Price = price,
                    TotalPrice = totalPrice
                };
                boxs.Add(currentBox);
                command = Console.ReadLine();
            }

            boxs = boxs.OrderByDescending(x => x.TotalPrice).ToList();
            foreach (var item in boxs)
            {
                Console.WriteLine(item.SerialNumber);
                Console.WriteLine($"-- {item.Name} - ${item.Price:F2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.TotalPrice:f2}");
            }
        }
    }
}
