namespace _11._Array_Manipulator
{
    using System;
    using System.Linq;
    class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] array = command.Split().ToArray();
                if (array[0] == "exchange")
                {
                    int index = int.Parse(array[1]);
                    if (index < 0 || index >= input.Length)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        GetNewArray(input, index);
                    }
                }
                else if (array[0] == "max")
                {
                    if (array[1] == "even")
                    {
                        PrintMaxIndexOfNumbers(input, 0);
                    }
                    else
                    {
                        PrintMaxIndexOfNumbers(input, 1);
                    }
                }
                else if (array[0] == "min")
                {
                    if (array[1] == "even")
                    {
                        PrintMinIndexOfNumbers(input, 0);
                    }
                    else if (array[1] == "odd")
                    {
                        PrintMinIndexOfNumbers(input, 1);
                    }
                }
                else if (array[0] == "first")
                {
                    int count = int.Parse(array[1]);
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (array[2] == "even")
                        {
                            PrintFirstCountOfNumbers(input, count, 0);
                        }
                        else if (array[2] == "odd")
                        {
                            PrintFirstCountOfNumbers(input, count, 1);
                        }
                    }
                }
                else if (array[0] == "last")
                {
                    int count = int.Parse(array[1]);
                    if (count > input.Length)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        if (array[2] == "even")
                        {
                            PrintLastCountOfNumbers(input, count, 0);
                        }
                        else if (array[2] == "odd")
                        {
                            PrintLastCountOfNumbers(input, count, 1);
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{string.Join(", ", input)}]");
        }

        public static void PrintLastCountOfNumbers(int[] input, int count, int v)
        {
            int counter = 0;
            int[] arr = new int[count];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] % 2 == v)
                {
                    arr[counter] = input[i];
                    counter++;
                    if (counter == count)
                    {
                        break;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else if (counter < count)
            {
                int[] array = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    array[i] = arr[i];
                }
                Console.WriteLine($"[{string.Join(", ", array.Reverse())}]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", arr.Reverse())}]");
            }
        }

        public static void PrintFirstCountOfNumbers(int[] input, int count, int v)
        {
            int counter = 0;
            int[] arr = new int[count];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == v)
                {
                    arr[counter] = input[i];
                    counter++;
                    if (counter == count)
                    {
                        break;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("[]");
            }
            else if (counter < count)
            {
                int[] array = new int[counter];
                for (int i = 0; i < counter; i++)
                {
                    array[i] = arr[i];
                }
                Console.WriteLine($"[{string.Join(", ", array)}]");
            }
            else
            {
                Console.WriteLine($"[{string.Join(", ", arr)}]");
            }
        }

        public static void PrintMinIndexOfNumbers(int[] input, int v)
        {
            int minValue = int.MaxValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == v && input[i] <= minValue)
                {
                    minValue = input[i];
                    maxIndex = i;
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        public static void PrintMaxIndexOfNumbers(int[] input, int v)
        {
            int maxValue = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == v && input[i] >= maxValue)
                {
                    maxValue = input[i];
                    maxIndex = i;
                }
            }
            if (maxIndex == -1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine(maxIndex);
            }
        }

        public static void GetNewArray(int[] input, int index)
        {
            int[] newArray = new int[input.Length + index + 1];
            for (int i = 0; i <= input.Length + index; i++)
            {
                if (i >= input.Length)
                {
                    newArray[i] = input[i - input.Length];
                }
                else
                {
                    newArray[i] = input[i];
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = newArray[i + index + 1];
            }
        }
    }
}

