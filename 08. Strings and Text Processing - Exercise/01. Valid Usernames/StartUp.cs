namespace _01._Valid_Usernames
{
    using System;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            List<string> users = new List<string>();
            string[] text = Console.ReadLine().Split(", ");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i].Length > 3 && text[i].Length < 16)
                {
                    bool isUser = true;
                    for (int j = 0; j < text[i].Length; j++)
                    {
                        if (text[i][j] >= 'a' && text[i][j] <= 'z' || text[i][j] >= 'A' && text[i][j] <= 'Z' 
                            || text[i][j] >= '0' && text[i][j] <= '9' || text[i][j] == '-' || text[i][j] == '-' 
                            || text[i][j] == '_')
                        {

                        }
                        else
                        {
                            isUser = false;
                            break;
                        }
                    }
                    if (isUser)
                    {
                        users.Add(text[i]);
                    }
                }
            }
            Console.WriteLine(string.Join("\n", users));
        }
    }
}
