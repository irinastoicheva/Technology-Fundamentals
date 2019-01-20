namespace _01._SoftUni_Reception
{
    using System;

    class Program
    {
        public static void Main()
        {
            int capacity1 = int.Parse(Console.ReadLine());
            int capacity2 = int.Parse(Console.ReadLine());
            int capacity3 = int.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());

            int capacityForHour = capacity1 + capacity2 + capacity3;
            int counter = 0;
            while (numberOfStudents > 0)
            {
                numberOfStudents -= capacityForHour;
                counter++;
                if (counter % 4 == 0)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Time needed: {counter}h.");
        }
    }
}
