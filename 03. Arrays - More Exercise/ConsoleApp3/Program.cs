
using System;
using System.Linq;


namespace P10.LadyBugs
{
    class Program
    {
        public static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] indexesWithBugs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] cells = new int[sizeOfField];

            for (int i = 0; i < indexesWithBugs.Length; i++)
            {
                if (indexesWithBugs[i] >= 0 && indexesWithBugs[i] < indexesWithBugs.Length)
                {
                    cells[indexesWithBugs[i]] = 1;
                }
            }

            string command = string.Empty;

            for (int j = 0; j < sizeOfField; j++)
            {
                command = Console.ReadLine();
                if (command != "end")
                {
                    string[] ladybugFly = command.Split().ToArray();
                    int ladybugIndex = int.Parse(ladybugFly[0]);
                    string direction = ladybugFly[1];
                    int flyLength = int.Parse(ladybugFly[2]);

                    for (int i = 0; i < cells.Length; i++)
                    {


                        if (direction == "right" && flyLength >= 0 && flyLength <= sizeOfField)
                        {
                            if (cells[i] == 1)
                            {
                                if (cells[i + 1] >= 1 && cells[i + 1] <= cells.Length)
                                {
                                    cells[i] = 0;
                                    cells[i + 1] = 1;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                cells[i] = 1;
                            }
                        }

                        else if (direction == "left" && flyLength >= 0 && flyLength <= sizeOfField)
                        {
                            if (cells[i] == 1)
                            {
                                if (cells[i - 1] >= 0 && cells[i - 1] <= cells.Length)
                                {
                                    cells[i] = 0;
                                    cells[i - 1] = 1;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                cells[i] = 1;
                            }
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(string.Join(" ", cells));
        }
    }
}
