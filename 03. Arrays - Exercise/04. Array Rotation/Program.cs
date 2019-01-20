namespace E04._Array_Rotation
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());

            if (rotation > arr.Length)
            {
                rotation = rotation % arr.Length;
            }
            for (int i = 0; i < rotation; i++)
            {
                int saveNumber = arr[0];
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[arr.Length - 1] = saveNumber;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}

