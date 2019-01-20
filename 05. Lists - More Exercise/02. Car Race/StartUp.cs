namespace _02._Car_Race
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                left.Add(input[i]);
                right.Add(input[input.Count - 1 - i]);
            }
            double timeLeftCar = GetTime(left);
            double timeRightCar = GetTime(right);

            if (timeLeftCar < timeRightCar)
            {
                Console.WriteLine($"The winner is left with total time: {timeLeftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {timeRightCar}");
            }
        }

        private static double GetTime(List<int> list)
        {
            double time = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == 0)
                {
                    time *= 0.8;
                }
                else
                {
                    time += list[i];
                }
            }
            return time;
        }
    }
}
