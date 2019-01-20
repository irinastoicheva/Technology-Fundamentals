namespace _02._Randomize_Words
{
    using System;
    using System.Linq;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            var random = new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int randomIndex = random.Next(0, input.Length);
                string temp = input[i];
                input[i] = input[randomIndex];
                input[randomIndex] = temp;
            }
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }
    }
}
