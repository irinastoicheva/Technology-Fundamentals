namespace _03._Extract_File
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { '\\', '.' }, StringSplitOptions.RemoveEmptyEntries);
            string fileName = input[input.Length - 2];
            string extension = input[input.Length - 1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
