namespace _03._Substring
{
    using System;

    class Program
    {
        public static void Main()
        {
            string key = Console.ReadLine().ToLower();
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                int indexOfKey = text.IndexOf(key);
                if (indexOfKey == -1)
                {
                    break;
                }
                text = text.Remove(indexOfKey, key.Length);
            }

            Console.WriteLine(text);
        }
    }
}
