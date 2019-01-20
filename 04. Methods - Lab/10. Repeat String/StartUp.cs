namespace _10._Repeat_String
{
    using System;
    using System.Text;
    class StartUp
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string output = RepeatString(input, number);
            Console.WriteLine(output);
        }

        public static string RepeatString(string input, int number)
        {
            StringBuilder newWord = new StringBuilder();
            for (int i = 0; i < number; i++)
            {
                newWord.Append(input);
            }
            return newWord.ToString();
        }
    }
}
