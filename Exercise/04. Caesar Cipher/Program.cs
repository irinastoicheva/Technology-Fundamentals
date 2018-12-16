namespace _04._Caesar_Cipher
{
    using System;
    using System.Text;

    class Program
    {
       public static void Main()
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append((char)(input[i] + 3));
            }
            Console.WriteLine(sb);
        }
    }
}
