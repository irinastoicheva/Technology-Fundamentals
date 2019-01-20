namespace _25.March._2018_02._Kamino_Factory
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int longestIncreasing = 1;
            List<int> save = new List<int>();
            int startIndex = 0;
            int sum = 0;
            int sample = 0;
            int counter = 0;
            for (int i = 0; i < number; i++)
            {
                save.Add(0);
            }
            while (command != "Clone them!")
            {
                counter++;
                int[] line = command.Split('!').Select(int.Parse).ToArray();
                int sumLine = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    sumLine += line[i];
                }
                for (int i = 0; i < line.Length - 1; i++)
                {
                    int sequence = 1;

                    if (line[i] == line[i + 1])
                    {
                        for (int j = i + 1; j < line.Length; j++)
                        {
                            sequence++;
                            if (sequence > longestIncreasing)
                            {
                                longestIncreasing = sequence;
                                startIndex = i;
                                sum = sumLine;
                                sample = counter;
                                save.RemoveRange(0, number);
                                for (int k = 0; k < number; k++)
                                {
                                    save.Add(line[k]);
                                }
                            }
                            else if (sequence == longestIncreasing && i < startIndex)
                            {
                                startIndex = i;
                                sum = sumLine;
                                sample = counter;
                                save.RemoveRange(0, number);
                                for (int k = 0; k < number; k++)
                                {
                                    save.Add(line[k]);
                                }
                            }
                            else if (sequence == longestIncreasing && startIndex == i && sumLine > sum)
                            {
                                sum = sumLine;
                                sample = counter;
                                save.RemoveRange(0, number);
                                for (int k = 0; k < number; k++)
                                {
                                    save.Add(line[k]);
                                }
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                command = Console.ReadLine();
            }
            if (sample == 0)
            {
                Console.WriteLine($"Best DNA sample 0 with sum: 0.");
                return;
            }
            Console.WriteLine($"Best DNA sample {sample} with sum: {sum}.");
            Console.WriteLine(string.Join(" ", save));
        }
    }
}
