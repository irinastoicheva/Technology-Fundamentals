namespace _01._Extract_Person_Information
{
    using System;
    using System.Text;

    class StartUp
    {
        public static void Main()
        {
            StringBuilder name = new StringBuilder();
            StringBuilder age = new StringBuilder();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string input = Console.ReadLine();
                name.Clear();
                age.Clear();

                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == '@')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            if (input[k] == '|')
                            {
                                break;
                            }
                            name.Append(input[k]);
                        }
                    }

                    if (input[j] == '#')
                    {
                        for (int k = j + 1; k < input.Length; k++)
                        {
                            if (input[k] == '*')
                            {
                                break;
                            }
                            age.Append(input[k]);
                        }
                    }
                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
