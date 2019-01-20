namespace _04._Text_Filter
{
    using System;

    class StartUp
    {
        public static void Main()
        {
            string[] keys = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] text = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < keys.Length; j++)
                {
                    if (text[i].Contains(keys[j]))
                    {
                        int index = text[i].IndexOf(keys[j]);
                        text[i] = text[i].Remove(index, keys[j].Length);
                        text[i] = text[i].Insert(index , new string('*', keys[j].Length));
                    }
                }
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
