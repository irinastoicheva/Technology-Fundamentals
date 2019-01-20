namespace _02._Pascal_triangle___
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string save = string.Empty;
            int[] arr = new int[number];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[0] = 1;
                for (int j = 0; j <= i; j++)
                {
                    if (i > 0)
                    {
                        int[] saveArray = save.Split().Select(int.Parse).ToArray();
                        if (j > 1)
                        {
                            arr[j] = saveArray[j - 1] + saveArray[j];
                        }
                        arr[0] = 1;
                        arr[1] = i;
                        arr[i] = 1;
                    }
                }
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[k] != 0)
                    {
                        Console.Write($"{arr[k]} ");
                    }
                }
                save = string.Join(" ", arr);
                Console.WriteLine();
            }
        }
    }
}

