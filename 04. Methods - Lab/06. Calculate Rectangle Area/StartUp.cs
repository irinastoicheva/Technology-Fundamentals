namespace _06._Calculate_Rectangle_Area
{
    using System;
    class StartUp
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = AreaOfRectangle(width, height);
            Console.WriteLine(area);
        }

        public static double AreaOfRectangle(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}
