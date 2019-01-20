namespace _09._Kamino_Factory
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int length = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int saveSumElements = 0;
            int maxCounter = 0;
            int[] totalArray = new int[length];
            int index = -1;
            int counterCommands = 0;
            int placeInTheArray = length - 1;

            while (command != "Clone them!")
            {
                counterCommands++;
                int[] arr = command.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int sumElements = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sumElements += arr[i];
                }
                if (counterCommands == 1)
                {
                    saveSumElements = sumElements;
                    index = 1;
                    totalArray = arr;
                }
                for (int j = 0; j < arr.Length; j++)
                {
                    int counter = 1;
                    for (int k = j + 1; k < arr.Length; k++)
                    {
                        if (arr[j] == arr[k])
                        {
                            counter++;
                            if (maxCounter < counter)
                            {
                                maxCounter = counter;
                                saveSumElements = sumElements;
                                index = counterCommands;
                                placeInTheArray = j;
                                    totalArray = arr;
                            }
                            if (j < placeInTheArray && maxCounter == counter)
                            {
                                maxCounter = counter;
                                saveSumElements = sumElements;
                                index = counterCommands;
                                placeInTheArray = j;
                                    totalArray = arr;
                            }
                            if (j <= placeInTheArray && maxCounter == counter && sumElements > saveSumElements)
                            {
                                maxCounter = counter;
                                saveSumElements = sumElements;
                                index = counterCommands;
                                placeInTheArray = j;

                                totalArray = arr;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {index} with sum: {saveSumElements}.");
            Console.WriteLine(string.Join(" ", totalArray));
        }
    }
}
