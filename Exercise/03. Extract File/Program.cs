namespace _03._Extract_File
{
    using System;

    class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split('\\', '.');
            Console.WriteLine($"File name: {input[input.Length - 2]}");
            Console.WriteLine($"File extension: {input[input.Length - 1]}");
        }
    }
}
