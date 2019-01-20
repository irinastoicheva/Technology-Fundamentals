namespace _03._Zig_Zag_Arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            List<int> num1 = new List<int>();
            List<int> num2 = new List<int>();

            for (int i = 0; i < number; i++)
            {
                int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j % 2 == 0)
                        {
                            num1.Add(arr[j]);
                        }
                        else
                        {
                            num2.Add(arr[j]);
                        }
                    }
                }
                else
                {
                    for (int j = 0; j < 2; j++)
                    {
                        if (j % 2 != 0)
                        {
                            num1.Add(arr[j]);
                        }
                        else
                        {
                            num2.Add(arr[j]);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", num1));
            Console.WriteLine(string.Join(" ", num2));
        }
    }
}
