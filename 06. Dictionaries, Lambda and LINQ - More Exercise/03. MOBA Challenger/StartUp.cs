namespace _03._MOBA_Challenger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            string command = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();

            while (command != "Season end")
            {
                string[] input = command.Split(" -> ").ToArray();
                if (input.Length == 3)
                {
                    string player = input[0];
                    string position = input[1];
                    int skill = int.Parse(input[2]);

                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        playerPositionSkill.Add(player, new Dictionary<string, int>());
                    }
                    if (!playerPositionSkill[player].ContainsKey(position))
                    {
                        playerPositionSkill[player].Add(position, 0);
                    }
                    if (playerPositionSkill[player][position] < skill)
                    {
                        playerPositionSkill[player][position] = skill;
                    }

                }
                else
                {
                    string[] inp = command.Split(" vs ").ToArray();
                    string firstPlayer = inp[0];
                    string secondPlayer = inp[1];

                    if (playerPositionSkill.ContainsKey(firstPlayer) && playerPositionSkill.ContainsKey(secondPlayer))
                    {
                        Dictionary<string, int> positionFirstPlayer = new Dictionary<string, int>();
                        foreach (var kvp in playerPositionSkill[firstPlayer])
                        {
                            positionFirstPlayer.Add(kvp.Key, kvp.Value);
                        }
                        Dictionary<string, int> positionSecondPlayer = new Dictionary<string, int>();
                        foreach (var kvp in playerPositionSkill[secondPlayer])
                        {
                            positionSecondPlayer.Add(kvp.Key, kvp.Value);
                        }

                        foreach (var kvp in positionFirstPlayer)
                        {
                            foreach (var item in positionSecondPlayer)
                            {
                                if (kvp.Key == item.Key)
                                {
                                    if (positionFirstPlayer[kvp.Key] > positionSecondPlayer[item.Key])
                                    {
                                        playerPositionSkill[secondPlayer].Remove(item.Key);
                                        if (playerPositionSkill[secondPlayer].Values.Sum() == 0)
                                        {
                                            playerPositionSkill.Remove(secondPlayer);
                                        }
                                    }
                                    else if (positionFirstPlayer[kvp.Key] < positionSecondPlayer[item.Key])
                                    {
                                        playerPositionSkill[firstPlayer].Remove(kvp.Key);
                                        if (playerPositionSkill[firstPlayer].Values.Sum() == 0)
                                        {
                                            playerPositionSkill.Remove(firstPlayer);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var kvp in playerPositionSkill.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Values.Sum()} skill");
                foreach (var item in kvp.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {item.Key} <::> {item.Value}");
                }
            }
        }
    }
}
