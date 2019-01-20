namespace _08._Vehicle_Catalogue
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class CatalogVehicle
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }

    class StartUp
    {
        public static void Main()
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            List<CatalogVehicle> catalogVehicle = new List<CatalogVehicle>();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] input = command.Split('/').ToArray();
                string vehicle = input[0];
                string brand = input[1];
                string model = input[2];
                int weight = int.Parse(input[3]);
                int HorsePower = int.Parse(input[3]);

                if (vehicle == "Truck")
                {
                    Truck currentTruck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };
                    trucks.Add(currentTruck);
                }
                else if (vehicle == "Car")
                {
                    Car currentCar = new Car
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = HorsePower
                    };
                    cars.Add(currentCar);
                }

                command = Console.ReadLine();
            }
            
            CatalogVehicle catalog = new CatalogVehicle
            {
                Cars = cars,
                Trucks = trucks
            };
            catalogVehicle.Add(catalog);

            foreach (var item in catalogVehicle.OrderBy(x => x.Cars).ThenBy(x => x.Trucks))
            {
                if (cars.Count > 0)
                {
                    Console.WriteLine($"Cars:");
                }
                foreach (var car in item.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }

                if (trucks.Count > 0)
                {
                    Console.WriteLine("Trucks:");

                }
                foreach (var truck in item.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }
        }
    }
}
