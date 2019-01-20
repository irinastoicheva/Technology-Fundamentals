namespace _01._Hogswatch
{
    using System;
    class StartUp
    {
        public static void Main()
        {
            int countOfHomes = int.Parse(Console.ReadLine());
            int initialNumberOfHomes = countOfHomes;
            int countOfPresents = int.Parse(Console.ReadLine());
            int firstPresents = countOfPresents;
            int extraPresents = 0;
            int timesBack = 0;

            while (countOfHomes > 0)
            {
                int countOfPresentsInHouse = int.Parse(Console.ReadLine());
                if (countOfPresents >= countOfPresentsInHouse)
                {
                    countOfPresents -= countOfPresentsInHouse;
                    if (countOfHomes == 1)
                    {
                        if (timesBack > 0)
                        {
                            Console.WriteLine(timesBack);
                            Console.WriteLine(extraPresents);
                        }
                        else
                        {
                            Console.WriteLine(countOfPresents);
                        }
                    }
                }
                else
                {
                    int neededPresentsForThisHome = countOfPresentsInHouse - countOfPresents;
                    timesBack++;
                    int extraPresentsNow = BackOfPresents(initialNumberOfHomes, countOfHomes, neededPresentsForThisHome, firstPresents);
                    extraPresents += extraPresentsNow;
                    countOfPresents = extraPresentsNow - neededPresentsForThisHome;
                    if (countOfHomes == 1)
                    {
                        if (timesBack > 0)
                        {
                            Console.WriteLine(timesBack);
                            Console.WriteLine(extraPresents);
                        }
                        else
                        {
                            Console.WriteLine(countOfPresents);
                        }
                    }
                }
                countOfHomes--;
            }
        }

        public static int BackOfPresents(int initialNumberOfHomes, int countOfHomes, int neededPresentsForThisHome, int firstPresents)
        {
            int countOfPresents = (firstPresents / (initialNumberOfHomes - countOfHomes + 1)) * (countOfHomes - 1) + neededPresentsForThisHome;
            return countOfPresents;
        }
    }
}
