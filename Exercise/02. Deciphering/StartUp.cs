namespace _02._Deciphering
{
    using System;
    using System.Linq;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (!((input[i] >= 100 && input[i] <= 122) || input[i] == '{' || input[i] == '}' || input[i] == '#' || input[i] == '|'))
                {
                    Console.WriteLine("This is not the book you are looking for.");
                    return;
                }
            }


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] - 3));
            }

            string[] input2 = Console.ReadLine().Split();
            sb.Replace(input2[0], input2[1]);

            Console.WriteLine(sb);
        }
    }
}
