namespace _05._01._2018_02._Snowmen
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        static void Main()
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (input.Count > 1)
            {
                for (int i = 0; i < input.Count; i++)
                {
                    List<int> lostIndexes = new List<int>();

                    int counter = input.Count;
                    if (counter == 1)
                    {
                        return;
                    }
                  //  if (!lostIndexes.Contains(i))
                   // {
                        int target = input[i];
                        if (target >= input.Count)
                        {
                            target %= input.Count;
                        }
                        if ((i - target) % 2 == 0 && i - target != 0)
                        {
                            lostIndexes.Add(target);
                            Console.WriteLine($"{i} x {target} -> {i} wins");
                            counter--;
                            if (counter == 1)
                            {
                                return;
                            }
                        }
                        else if ((i - target) % 2 != 0 && (i - target) != 0)
                        {
                            Console.WriteLine($"{i} x {target} -> {target} wins");
                            lostIndexes.Add(i);
                            counter--;
                            if (counter == 1)
                            {
                                return;
                            }
                        }
                        else if (i - target == 0)
                        {
                            lostIndexes.Add(i);
                            Console.WriteLine($"{i} performed harakiri");
                            counter--;
                            if (counter == 1)
                            {
                                return;
                            }
                        }
                    //}
                    lostIndexes = lostIndexes.OrderByDescending(x => x).ToList();
                    for (int j = 0; j < lostIndexes.Count; j++)
                    {
                        int index = lostIndexes[j];
                        input.RemoveAt(index);
                    }
                }
            }
        }
    }
}
