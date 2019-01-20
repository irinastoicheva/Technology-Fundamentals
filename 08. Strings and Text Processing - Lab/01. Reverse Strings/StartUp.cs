namespace _01._Reverse_Strings
{
    using System;
    using System.Text;

    class StartUp
    {
       public static void Main()
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                string word = command;
                StringBuilder sb = new StringBuilder();
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    sb.Append(word[i]);
                }
                Console.WriteLine($"{word} = {sb.ToString()}");

                command = Console.ReadLine();
            }
        }
    }
}
