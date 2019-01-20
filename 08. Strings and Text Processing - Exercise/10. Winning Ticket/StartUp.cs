namespace _10._Winning_Ticket
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string ticket = input[i];

                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftPiece = ticket.Substring(0, 10);
                    string rightPiece = ticket.Substring(10);

                    Dictionary<char, int> longestInLeftPiece = GetTheLongestSequence(leftPiece);
                    Dictionary<char, int> longestInRightPiece = GetTheLongestSequence(rightPiece);

                    int length = 0;
                    char symbol = ' ';
                    bool isValidSymbol = false;
                    foreach (var item in longestInLeftPiece)
                    {
                        foreach (var item1 in longestInRightPiece)
                        {
                            if (item.Key == item1.Key && (item.Key == '@' || item.Key == '#' || item.Key == '^' || item.Key == '$'))
                            {
                                length = Math.Min(item.Value, item1.Value);
                                symbol = item.Key;
                                isValidSymbol = true;
                            }
                        }
                    }
                    if (length == 10 && isValidSymbol)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol} Jackpot!");
                    }
                    else if (length > 5 && isValidSymbol)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {length}{symbol}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }

        public static Dictionary<char, int> GetTheLongestSequence(string piece)
        {
            char symbol = ' ';
            int maxLength = 0;
            for (int i = 0; i < piece.Length; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < piece.Length; j++)
                {
                    if (piece[i] == piece[j])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                        break;
                    }
                    if (maxLength < counter)
                    {
                        maxLength = counter;
                        symbol = piece[i];
                    }
                }
            }
            Dictionary<char, int> longestInPiece = new Dictionary<char, int>();
            longestInPiece.Add(symbol, maxLength);
            return longestInPiece;
        }
    }
}
