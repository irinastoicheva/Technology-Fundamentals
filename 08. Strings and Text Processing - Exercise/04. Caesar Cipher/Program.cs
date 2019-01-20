namespace _04._Caesar_Cipher
{
    using System;

    class Program
    {
        public static void Main()
        {
            char[] text = Console.ReadLine().ToCharArray();
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = (char)((int)text[i] + 3);
            }
            Console.WriteLine(string.Join("", text));
        }
    }
}
