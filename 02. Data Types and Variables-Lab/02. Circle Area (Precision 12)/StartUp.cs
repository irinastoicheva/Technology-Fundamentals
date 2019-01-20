namespace _02._Circle_Area__Precision_12_
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double radius = double.Parse(Console.ReadLine());
            double area = Math.PI * radius * radius ;
            Console.WriteLine($"{area:f12}");
        }
    }
}
