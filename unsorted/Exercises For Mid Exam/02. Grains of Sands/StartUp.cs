namespace _02._Grains_of_Sands
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        public static void Main()
        {
            List<int> number = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "Mort")
            {
                string[] array = command.Split().ToArray();
                string com = array[0];
                int value = int.Parse(array[1]);

                switch (com)
                {
                    case "Add":
                        number.Add(value);
                        break;
                    case "Remove":
                       number = RemoveI(number, value);
                        break;
                    case "Replace":
                        int replacement = int.Parse(array[2]);
                        number = ReplaceI(number, value, replacement);
                        break;
                    case "Increase":
                        number = Increase(number, value);
                        break;
                    case "Collapse":
                        number = Collapse(number, value);
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", number));
        }

        public static List<int> Collapse(List<int> number, int value)
        {
            for (int i = 0; i < number.Count; i++)
            {
                if (number [i] < value)
                {
                    number.RemoveAt(i);
                    i--;
                }
            }
            return number;
        }

        public static List<int> Increase(List<int> number, int value)
        {
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] >= value)
                {
                    int save = number[i];
                    for (int j = 0; j < number.Count; j++)
                    {
                        number[j] += save;
                    }
                    return number;
                }
            }
            for (int i = 0; i < number.Count; i++)
            {
                number[i] += number[number.Count - 1];
            }
            return number;
        }

        public static List<int> ReplaceI(List<int> number, int value, int replacement)
        {
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == value)
                {
                    number[i] = replacement;
                    return number;
                }
            }
            return number;
        }

        public static List <int> RemoveI(List<int> number, int value)
        {
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] == value)
                {
                    number.Remove(value);
                    return number;
                }
            }
            if (value < number.Count)
            {
                number.RemoveAt(value);
                return number;
            }
            return number;
        }
    }
}
