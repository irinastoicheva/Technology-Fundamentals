namespace _04._Raw_Data
{
    using System;
    using System.Collections.Generic;

    public class Cars
    {
        public Cars(string model, Engine engine, Cargo cargo)
        {
            Model = model;
            CarEngineSpeed = engine.EngineSpeed;
            CarEnginePower = engine.EnginePower;
            CargoWeight = cargo.CargoWeight;
            CargoType = cargo.CargoType;
        }
        public string Model { get; set; }
        public int CarEngineSpeed { get; set; }
        public int CarEnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    public class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }
    public class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> list = new List<Cars>();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine currentEngine = new Engine(engineSpeed, enginePower);
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);
                Cars currentCar = new Cars(model, currentEngine, currentCargo);
                list.Add(currentCar);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                foreach (var item in list)
                {
                    if (item.CargoType == "fragile" && item.CargoWeight < 1000)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var item in list)
                {
                    if (item.CargoType == "flamable" && item.CarEnginePower > 250)
                    {
                        Console.WriteLine(item.Model);
                    }
                }
            }
        }
    }
}
