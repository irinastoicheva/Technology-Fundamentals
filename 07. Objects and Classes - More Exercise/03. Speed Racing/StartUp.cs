namespace _03._Speed_Racing
{
    using System;
    using System.Collections.Generic;

    public class Cars
    {
        public Cars(string model, double fuelAmount, double fuelConsumptionFor1km, double distanceTraveled)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km = fuelConsumptionFor1km;
            DistanceTraveled = distanceTraveled;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public double DistanceTraveled { get; set; }
    }

    public class Drive
    {
        public List<Cars> Cars { get; set; }
        public Drive()
        {
            Cars = new List<Cars>();
        }
        public void AddCar(Cars currentCar)
        {
            Cars.Add(currentCar);
        }
        public bool IsWhetherTheCarCanMoveThatDistance(string model, double amountOfKm)
        {
            foreach (var item in Cars)
            {
                if (item.Model == model)
                {
                    if (item.FuelAmount / item.FuelConsumptionFor1km >= amountOfKm)
                    {
                        item.DistanceTraveled += amountOfKm;
                        item.FuelAmount -= amountOfKm * item.FuelConsumptionFor1km;
                        return true;
                    }
                }
            }
            return false;
        }
    }
    class StartUp
    {
        public static void Main()
        {
            Drive Drive = new Drive();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                double distanceTraveled = 0;

                Cars currentCar = new Cars(model, fuelAmount, fuelConsumptionFor1km, distanceTraveled);
                Drive.AddCar(currentCar);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] input = command.Split();
                string model = input[1];
                double amountOfKm = double.Parse(input[2]);

                if (!Drive.IsWhetherTheCarCanMoveThatDistance(model, amountOfKm))
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }
            foreach (var item in Drive.Cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.DistanceTraveled}");
            }
        }
    }
}
