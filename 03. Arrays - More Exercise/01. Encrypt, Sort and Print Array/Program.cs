namespace P01.EncryptSortAndPrintArray
{
    using System;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            int numberOfStrings = int.Parse(Console.ReadLine());
            int[] podredenMasiv = new int[numberOfStrings];
            for (int i = 0; i < numberOfStrings; i++)
            {
                string input = Console.ReadLine();
                int[] arr = new int[input.Length];
                int sum = 0;

                for (int j = 0; j < input.Length; j++)
                {
                    arr[j] = input[j];
                    if (arr[j] == 65 || arr[j] == 69 || arr[j] == 73 || arr[j] == 85 || arr[j] == 79 || arr[j] == 97 || arr[j] == 101 || arr[j] == 105 || arr[j] == 157 || arr[j] == 117 || arr[j] == 111)
                    {
                        sum += arr[j] * arr.Length;
                    }
                    else
                    {
                        sum += arr[j] / arr.Length;
                    }
                }
                podredenMasiv[i] = sum;
            }
            Array.Sort(podredenMasiv);
            foreach (var item in podredenMasiv)
            {
                Console.WriteLine(item);
            }
        }
    }
}
