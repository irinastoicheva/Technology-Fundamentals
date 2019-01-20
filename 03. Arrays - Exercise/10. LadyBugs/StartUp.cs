namespace _10._LadyBugs
{
    using System;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            int field = int.Parse(Console.ReadLine());

            int [] placeOfLadybirdsInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] placeOfLadybirds = new int[field];
            for (int j = 0; j < placeOfLadybirdsInput.Length; j++)
            {
                if (placeOfLadybirdsInput[j] >= 0 && placeOfLadybirdsInput[j] < placeOfLadybirds.Length)
                {
                    placeOfLadybirds[placeOfLadybirdsInput[j]] = 1;
                }
            }
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] arr = command.Split().ToArray();
                int fromIndex = int.Parse(arr[0]);
                string directionOfFlying = arr[1];
                int length = int.Parse(arr[2]);

                if (fromIndex >= 0 && fromIndex < placeOfLadybirds.Length)
                {
                    if (placeOfLadybirds[fromIndex] == 1)
                    {
                        placeOfLadybirds[fromIndex] = 0;
                        if (directionOfFlying == "right")
                        {
                            if (fromIndex + length < placeOfLadybirds.Length && fromIndex + length >= 0)
                            {
                                if (placeOfLadybirds[fromIndex + length] == 0)
                                {
                                    placeOfLadybirds[fromIndex + length] = 1;
                                }
                                else
                                {
                                    for (int i = 2; i < int.MaxValue; i++)
                                    {
                                        if ((fromIndex + (i * length)) >= placeOfLadybirds.Length || (fromIndex + (i * length)) < 0)
                                        {
                                            break;
                                        }
                                        else if (placeOfLadybirds[fromIndex + (i * length)] == 0)
                                        {
                                            placeOfLadybirds[fromIndex + (i * length)] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        else if (directionOfFlying == "left")
                        {
                            if (fromIndex - length >= 0 && fromIndex - length < placeOfLadybirds.Length)
                            {
                                if (placeOfLadybirds[fromIndex - length] == 0)
                                {
                                    placeOfLadybirds[fromIndex - length] = 1;
                                }
                                else
                                {
                                    for (int i = 2; i < int.MaxValue; i++)
                                    {
                                        if (fromIndex - (i * length) < 0 || fromIndex - (i * length) >= placeOfLadybirds.Length)
                                        {
                                            placeOfLadybirds[fromIndex] = 0;
                                            break;
                                        }
                                        else if (placeOfLadybirds[fromIndex - (i * length)] == 0)
                                        {
                                            placeOfLadybirds[fromIndex] = 0;
                                            placeOfLadybirds[fromIndex - (i * length)] = 1;
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                placeOfLadybirds[fromIndex] = 0;
                            }
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", placeOfLadybirds));
        }
    }
}
