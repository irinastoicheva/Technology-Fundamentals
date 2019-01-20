namespace _02._Repeat_Strings
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb);
        }
    }
}
