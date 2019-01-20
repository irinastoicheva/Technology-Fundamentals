namespace _04._Elevator
{
    using System;

    class StartUp
    {
        static void Main()
        {
            double numberOfPeople = double.Parse(Console.ReadLine());
            double capacity = double.Parse(Console.ReadLine());

            double counter = Math.Ceiling(numberOfPeople/capacity);
            Console.WriteLine(counter);                      
        }
    }
}
