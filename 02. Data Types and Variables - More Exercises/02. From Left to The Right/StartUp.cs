namespace _02._From_Left_to_The_Right
{
    using System;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                long [] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
                long leftNumber = arr[0];
                long rightNumber = arr[1];

                if (leftNumber > rightNumber)
                {
                    long left = Math.Abs(leftNumber);
                    long sum = 0;
                    while (left > 0)
                    {
                        sum += left % 10;
                        left /= 10;
                    }
                    Console.WriteLine(sum);
                }
                else
                {
                    long right = Math.Abs(rightNumber);
                    long sum = 0;
                    while (right > 0)
                    {
                        sum += right % 10;
                        right /= 10;
                    }
                    Console.WriteLine(sum);
                }
            }
        }
    }
}
