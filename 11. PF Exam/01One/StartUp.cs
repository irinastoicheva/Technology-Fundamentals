namespace _01One
{
    using System;
    using System.Linq;

    class StartUp
    {
        public static void Main()
        {
            int partySize = int.Parse(Console.ReadLine());
            int numberOfDayd = int.Parse(Console.ReadLine());
            int money = 0;
            for (int i = 1; i <= numberOfDayd; i++)
            {
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }
                if (i % 15 == 0)
                {
                    partySize += 5;
                }
                
                money += 50;
                money -= partySize * 2;

                if (i % 3 == 0)
                {
                    money -= partySize * 3;
                }
                if (i % 5 == 0)
                {
                    money += 20 * partySize;
                }

                if (i % 15 == 0)
                {
                    money -= partySize * 2;
                }
            }
            Console.WriteLine($"{partySize} companions received {money / partySize} coins each.");
        }
    }
}
