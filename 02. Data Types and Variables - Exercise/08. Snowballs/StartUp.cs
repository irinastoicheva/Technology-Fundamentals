namespace _08._Snowballs
{
    using System;
    using System.Numerics;

    class StartUp
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger theBestSnowballValue = 0;
            int snowballSnowMemory = 0;
            int snowballTimeMemory = 0;
            int snowballQualityMemory = 0;

            for (int i = 1; i <= number; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > theBestSnowballValue)
                {
                    theBestSnowballValue = snowballValue;
                    snowballSnowMemory = snowballSnow;
                    snowballTimeMemory = snowballTime;
                    snowballQualityMemory = snowballQuality;
                }
            }
            Console.WriteLine($"{snowballSnowMemory} : {snowballTimeMemory} = {theBestSnowballValue} ({snowballQualityMemory})");
        }
    }
}
