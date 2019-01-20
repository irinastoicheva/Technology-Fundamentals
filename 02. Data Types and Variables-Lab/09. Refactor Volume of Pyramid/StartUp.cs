namespace _09._Refactor_Volume_of_Pyramid
{
    using System;

    class StartUp
    {
        static void Main()
        {
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double volume = (length * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:F2}");
        }
    }
}
